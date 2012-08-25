using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K3Key
{
    internal sealed class DataReceivedEventArgs : EventArgs
    {
        public string Port { get; private set; }
        public string Data { get; private set; }

        public DataReceivedEventArgs(string port, string data)
        {
            Port = port;
            Data = data;
        }
    }
}
