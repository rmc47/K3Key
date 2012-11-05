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

        private void m_Connect_Click(object sender, EventArgs e)
        {
            m_WinKey = new FakeWinKey("COM12A", m_Bridge);
            //m_WinKey.DataReceived += new EventHandler<DataReceivedEventArgs>(WinKeyDataReceived);
        }

        private void AppendText(RichTextBox box, string text)
        {
            return;
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
            }
            if (m_K3SerialChoice.SelectedIndex >= 0 && m_VirtualK3Choice.SelectedIndex >= 0)
            {
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

                try
                {
                    m_Bridge = new SerialBridge(m_K3SerialChoice.Text, m_VirtualK3Choice.Text, 4800);
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
