using GEV.UMP.Core.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEV.UMP.Core;
using GEV.UMP.Core.Data;
using System.IO.Ports;
using System.Threading;
using System.Collections.Concurrent;

namespace GEV.UMP.Utils
{
    public abstract class SerialDevice : IDevice
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public ComponentStatus Status { get; set; }
        public List<StatusMessage> StatusMessages { get; } = new List<StatusMessage>();

        protected ConcurrentQueue<string> WriteBuffer { get; } = new ConcurrentQueue<string>();

        public event EventHandler<string> MessageRead;

        protected SerialPort m_SerialPort;
        protected Thread m_PortReader;
        protected bool m_PortEnabled;

        public void Close()
        {
            if(this.m_SerialPort != null && this.m_SerialPort.IsOpen)
            {
                this.m_SerialPort.Close();
            }
        }

        public bool Open()
        {
            try
            {
                this.m_SerialPort = new SerialPort(this.Address);
                this.m_SerialPort.Open();

                this.m_PortEnabled = true;

                this.m_PortReader = new Thread(new ThreadStart(this.ThreadRunner));
                this.m_PortReader.IsBackground = true;
                this.m_PortReader.Start();

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private void ThreadRunner()
        {
            while(this.m_PortEnabled)
            {
                if (this.m_SerialPort.BytesToRead > 0)
                {
                    string s = this.m_SerialPort.ReadLine();
                    this.MessageRead?.Invoke(this, s);
                }

                string msg = null;
                if(this.WriteBuffer.TryDequeue(out msg))
                {
                    this.m_SerialPort.WriteLine(msg);
                }

                Thread.Sleep(5);
            }
        }
    }
}
