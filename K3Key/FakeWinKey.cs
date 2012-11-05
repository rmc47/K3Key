using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;

namespace K3Key
{
    class FakeWinKey : IDisposable
    {
        private SerialPort m_Port;
        private bool m_HostOpen;
        private SerialBridge m_Bridge;

        public event EventHandler<DataReceivedEventArgs> DataReceived;
        public event EventHandler ErrorRaised;

        public SerialBridge Bridge
        {
            get { return m_Bridge; }
            set { m_Bridge = value; }
        }

        public FakeWinKey(string serialPort, SerialBridge bridge)
        {
            m_Bridge = bridge;

            m_Port = new SerialPort(serialPort);
            m_Port.BaudRate = 1200;
            m_Port.Open();
            Thread t = new Thread(ProcessThread);
            t.IsBackground = true;
            t.Start();
        }

        private void ProcessThread()
        {
            try
            {
                while (true)
                {
                    int cmd = m_Port.ReadByte();
                    switch (cmd)
                    {
                        case 0: // Admin
                            ProcessAdmin();
                            break;
                        case 1: // Sidetone
                        case 2: // Set WPM
                        case 3: // Weighting
                            IgnoreCommand(1);
                            break;
                        case 4: // PTT lead
                            IgnoreCommand(2);
                            break;
                        case 5: // Setup speed pot
                            IgnoreCommand(3);
                            break;
                        case 6: // Set pause
                            IgnoreCommand(1);
                            break;
                        case 7: // Get speed pot
                            Write(0x80 + 0);
                            break;
                        case 8: // Backspace
                            break;
                        case 9: // Set pin config
                            IgnoreCommand(1);
                            break;
                        case 0xA: // Clear buffer
                            break;
                        case 0xB: // Key immediate
                        case 0xC: // Set HSCW
                        case 0xD: // Set Farns WPM
                        case 0xE:
                            IgnoreCommand(1);
                            break;
                        case 0xF: // Load defaults
                            IgnoreCommand(15);
                            break;
                        case 0x10: // 1st Extension
                        case 0x11: // Key Comp
                        case 0x12: // Paddle switchpoint
                            IgnoreCommand(1);
                            break;
                        case 0x13: // NOP
                            break;
                        case 0x14: // Software paddle
                            IgnoreCommand(1);
                            break;
                        case 0x15: // Get status
                            Write(0xC0);
                            break;
                        case 0x16: // Input buffer command set
                            IgnoreCommand(1); // TODO: not technically correct, but hopefully not used...
                            break;
                        case 0x17: // Dit dah ratio
                            IgnoreCommand(1);
                            break;
                        case 0x18:
                        case 0x19:
                        case 0x1A:
                            IgnoreCommand(1);
                            break;
                        case 0x1B: // Merge letter
                            break; // Let the two carry on unmerged
                        case 0x1C: // Change speed buffered
                        case 0x1D: // HSCW speed change
                            IgnoreCommand(1);
                            break;
                        case 0x1E: // Cancel buffered speed change
                        case 0x1F: // Buffered NOP
                            break;
                        default:
                            // Just a character!
                            Write((byte)cmd);
                            Debug.Write(((char)cmd).ToString());
                            if (m_Bridge != null)
                                m_Bridge.InjectData("KY " + ((char)cmd).ToString() + ";");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                OnErrorRaised();
            }
        }

        private void ProcessAdmin()
        {
            int cmd = m_Port.ReadByte();
            switch (cmd)
            {
                case 0: // Calibrate
                    // Wait for the next FF
                    m_Port.ReadByte();
                    break;
                case 1: // Reset
                    m_HostOpen = false;
                    break;
                case 2: // Host open
                    m_HostOpen = true;
                    Write(25); // Version
                    break;
                case 3: // Host close
                    m_HostOpen = false;
                    break;
                case 4: // Echo test
                    Write((byte)m_Port.ReadByte());
                    break;
                case 5: // Paddle A2D
                    Write(255);
                    break;
                case 6: // Speed A2D
                    Write(0);
                    break;
                case 7: // Get Values
                    break;
                case 8: // Reserved
                    break;
                case 9: // Get cal
                    Write(0);
                    break;
            }
        }

        private void IgnoreCommand(int bytesToConsume)
        {
            for (int i = 0; i < bytesToConsume; i++)
                m_Port.ReadByte();
        }

        private void Write(byte buff)
        {
            m_Port.Write(new[] { buff }, 0, 1);
        }
        private void Write(byte[] buff)
        {
            m_Port.Write(buff, 0, buff.Length);
        }

        private void OnErrorRaised()
        {
            if (ErrorRaised != null)
                ErrorRaised(this, new EventArgs());
        }

        public void Dispose()
        {
            if (m_Port != null)
            {
                try
                {
                    if (m_Port.IsOpen)
                        m_Port.Close();
                }
                catch { }
                m_Port.Dispose();
                m_Port = null;
            }
        }
    }
}
