using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace K3Key
{
    public partial class MainForm : Form
    {
        private SerialBridge m_Bridge;
        private FakeWinKey m_WinKey;
        private int m_CurrentCATSpeed = 4800;

        public MainForm()
        {
            InitializeComponent();

            string[] serialPortNames = SerialPort.GetPortNames();
            m_K3SerialChoice.Items.Clear();
            m_VirtualK3Choice.Items.Clear();
            m_VirtualWinKeyChoice.Items.Clear();
            m_K3SerialChoice.Items.AddRange(serialPortNames);
            m_VirtualK3Choice.Items.AddRange(serialPortNames);
            m_VirtualWinKeyChoice.Items.AddRange(serialPortNames);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Restore the previously selected values
            string realK3Serial = Settings.Get("RealK3Serial", null);
            if (realK3Serial != null)
                m_K3SerialChoice.SelectedItem = realK3Serial;
            string virtualK3Serial = Settings.Get("VirtualK3Serial", null);
            if (virtualK3Serial != null)
                m_VirtualK3Choice.SelectedItem = virtualK3Serial;
            string virtualWinKeySerial = Settings.Get("VirtualWinKeySerial", null);
            if (virtualWinKeySerial != null)
                m_VirtualWinKeyChoice.SelectedItem = virtualWinKeySerial;
            string catSpeed = Settings.Get("CATSpeed", null);
            if (catSpeed != null)
                m_CATSpeed.SelectedItem = catSpeed;
        }

        private void AppendText(RichTextBox box, string text)
        {
            Invoke(new MethodInvoker(() =>
            {
                box.AppendText(text + "\r\n");
                box.ScrollToCaret();
            }));
        }

        private void BridgePortChanged(object sender, EventArgs e)
        {
            if (m_Bridge != null)
            {
                m_Bridge.Dispose();
                m_Bridge = null;
                if (m_WinKey != null)
                    m_WinKey.Bridge = null;
            }
            if (m_K3SerialChoice.SelectedIndex >= 0 && m_VirtualK3Choice.SelectedIndex >= 0)
            {
                Settings.Set("RealK3Serial", m_K3SerialChoice.Text);
                Settings.Set("VirtualK3Serial", m_VirtualK3Choice.Text);
                if (!string.IsNullOrEmpty(m_CATSpeed.Text))
                    Settings.Set("CATSpeed", m_CATSpeed.Text);

                bool bothOK = true;
                m_VirtualK3Status.Text = m_K3SerialStatus.Text = string.Empty;
                if (!TestOpenSerialPort(m_K3SerialChoice.Text))
                {
                    m_K3SerialStatus.Text = "Error opening port";
                    bothOK = false;
                }
                if (!TestOpenSerialPort(m_VirtualK3Choice.Text))
                {
                    m_VirtualK3Status.Text = "Error opening port";
                    bothOK = false;
                }

                if (bothOK)
                {
                    try
                    {
                        m_Bridge = new SerialBridge(m_K3SerialChoice.Text, m_VirtualK3Choice.Text, m_CurrentCATSpeed);
                        m_Bridge.RealRadioErrorReceived += new EventHandler(RealRadioErrorReceived);
                        m_Bridge.FakeRadioErrorReceived += new EventHandler(FakeRadioErrorReceived);
                        if (m_WinKey != null)
                            m_WinKey.Bridge = m_Bridge;

                        m_K3SerialStatus.Text = m_VirtualK3Status.Text = "Connected";
                    }
                    catch (Exception ex)
                    {
                        m_K3SerialStatus.Text = m_VirtualK3Status.Text = "Error creating bridge";
                    }
                }
            }
        }

        private void CATSpeedChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(m_CATSpeed.Text))
                return;

            Settings.Set("CATSpeed", m_CATSpeed.Text);
            int catSpeed;
            if (!int.TryParse(m_CATSpeed.Text, out catSpeed) || catSpeed < 1000 || catSpeed > 100000)
                catSpeed = 4800; // Sensible default

            m_CurrentCATSpeed = catSpeed;
            if (m_Bridge != null)
                m_Bridge.BaudRate = catSpeed;
        }

        private void WinKeyPortChanged(object sender, EventArgs e)
        {
            if (m_WinKey != null)
            {
                m_WinKey.Dispose();
                m_WinKey = null;
            }
            if (m_VirtualWinKeyChoice.SelectedIndex >= 0)
            {
                Settings.Set("VirtualWinKeySerial", m_VirtualWinKeyChoice.Text);
                m_VirtualWinKeyStatus.Text = string.Empty;
                if (!TestOpenSerialPort(m_VirtualWinKeyChoice.Text))
                {
                    m_VirtualWinKeyStatus.Text = "Error opening port";
                }
                else
                {
                    m_WinKey = new FakeWinKey(m_VirtualWinKeyChoice.Text, m_Bridge);
                    m_VirtualWinKeyStatus.Text = "Connected";
                }
            }
        }

        void FakeRadioErrorReceived(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                m_K3SerialStatus.Text = "Port error";
            }));
        }

        void RealRadioErrorReceived(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                m_VirtualK3Status.Text = "Port error";
            }));
        }

        private bool TestOpenSerialPort(string port)
        {
            try
            {
                using (System.IO.Ports.SerialPort p = new System.IO.Ports.SerialPort(port))
                {
                    p.Open();
                    p.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
