﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace K3Key
{
    internal sealed class SerialBridge : IDisposable
    {
        private SerialPort m_RealRadio;
        private SerialPort m_FakeRadio;

        public EventHandler<DataReceivedEventArgs> DataReceived;

        public SerialBridge(string realRadioPort, string fakeRadioPort, int baud)
        {
            try
            {
                m_RealRadio = new SerialPort(realRadioPort);
                m_FakeRadio = new SerialPort(fakeRadioPort);
                m_RealRadio.BaudRate = m_FakeRadio.BaudRate = baud;
                m_RealRadio.Open();
                m_FakeRadio.Open();
                m_RealRadio.DataReceived += new SerialDataReceivedEventHandler(m_RealRadio_DataReceived);
                m_FakeRadio.DataReceived += new SerialDataReceivedEventHandler(m_FakeRadio_DataReceived);
            }
            catch
            {
                if (m_RealRadio != null)
                    m_RealRadio.Dispose();
                if (m_FakeRadio != null)
                    m_FakeRadio.Dispose();
                throw;
            }
        }

        public void InjectData(string data)
        {
            if (m_FakeRadio == null)
                throw new ObjectDisposedException("Cannot inject data after SerialBridge Disposed");

            lock (m_FakeRadio)
            {
                m_RealRadio.Write(data);
            }
        }

        private void m_FakeRadio_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (m_FakeRadio == null || m_RealRadio == null) // Tidying up during dispose
                return;

            lock (m_FakeRadio)
            {
                while (m_FakeRadio.BytesToRead > 0)
                {
                    byte[] buff = new byte[m_FakeRadio.BytesToRead];
                    int read = m_FakeRadio.Read(buff, 0, buff.Length);
                    m_RealRadio.Write(buff, 0, read);
                    OnDataReceived("WT_RAD", Encoding.ASCII.GetString(buff, 0, read));
                }
            }
        }

        private void m_RealRadio_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (m_FakeRadio == null || m_RealRadio == null) // Tidying up during dispose
                return;

            lock (m_RealRadio)
            {
                while (m_RealRadio.BytesToRead > 0)
                {
                    byte[] buff = new byte[m_RealRadio.BytesToRead];
                    int read = m_RealRadio.Read(buff, 0, buff.Length);
                    m_FakeRadio.Write(buff, 0, read);
                    OnDataReceived("RADIO", Encoding.ASCII.GetString(buff, 0, read));
                }
            }
        }

        private void OnDataReceived(string port, string data)
        {
            if (DataReceived != null)
                DataReceived(this, new DataReceivedEventArgs(port, data));
        }

        public void Dispose()
        {
            if (m_RealRadio != null)
            {
                if (m_RealRadio.IsOpen)
                    m_RealRadio.Close();
                m_RealRadio.Dispose();
                m_RealRadio = null;
            }
            if (m_FakeRadio != null)
            {
                if (m_FakeRadio.IsOpen) ;
                m_FakeRadio.Close();
                m_FakeRadio.Dispose();
                m_FakeRadio = null;
            }
        }
    }
}
