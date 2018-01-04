using Cognex.DataMan.SDK;
using GEV.UMP.Core.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Devices.Cognex.DataMan
{
    public class DataManCodeReader : ICaptureDevice
    {
        public string Address { get; set; }

        public event EventHandler SampleCaptured;

        public void Capture()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void EndCapture()
        {
            throw new NotImplementedException();
        }

        public bool Open()
        {
            EthSystemConnector conn = new EthSystemConnector(IPAddress.Parse(this.Address));

            conn.UserName = "admin";

            DataManSystem cam = new DataManSystem(conn);
            cam.Connect();

            ResultTypes requested_result_types = ResultTypes.ReadXml | ResultTypes.Image | ResultTypes.ImageGraphics;
            _results = new ResultCollector(_system, requested_result_types);
            _results.ComplexResultArrived += Results_ComplexResultArrived;
            _results.PartialResultDropped += Results_PartialResultDropped;


            return true;
        }

        public void StartCapture()
        {
            throw new NotImplementedException();
        }
    }
}
