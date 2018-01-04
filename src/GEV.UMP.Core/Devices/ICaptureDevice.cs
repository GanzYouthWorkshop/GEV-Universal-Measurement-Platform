using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Devices
{
    public interface ICaptureDevice : IDevice
    {
        void StartCapture();
        void EndCapture();
        void Capture();

        event EventHandler SampleCaptured;
    }
}
