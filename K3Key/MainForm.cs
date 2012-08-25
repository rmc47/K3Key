using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void m_Connect_Click(object sender, EventArgs e)
        {
            m_Bridge = new SerialBridge("COM1", "COM11A", 4800);
            m_Bridge.DataReceived += BridgeDataReceived;

            m_WinKey = new FakeWinKey("COM12A", m_Bridge);
            m_WinKey.DataReceived += new EventHandler<DataReceivedEventArgs>(WinKeyDataReceived);
        }

        void WinKeyDataReceived(object sender, DataReceivedEventArgs e)
        {
            AppendText(m_RtfWinKey, e.Data);
        }

        private void BridgeDataReceived(object sender, DataReceivedEventArgs e)
        {
            AppendText(m_RtfRadio, string.Format("[{0}] {1}", e.Port, e.Data));
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
    }
}
