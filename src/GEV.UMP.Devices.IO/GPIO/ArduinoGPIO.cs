using GEV.UMP.Core.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEV.UMP.Core.Data;

namespace GEV.UMP.Devices.IO.GPIO
{
    public class ArduinoGPIO : IInputDevice, IOutputDevice
    {
        public KeyedCollection<IOVariable> Values { get; }

        public void ReadAllValues()
        {
            throw new NotImplementedException();
        }

        public void ReadValue(string value)
        {
            throw new NotImplementedException();
        }

        public void ReadValues(List<string> values)
        {
            throw new NotImplementedException();
        }

        public void WriteValue(string name, object value)
        {
            throw new NotImplementedException();
        }

        public void WriteValues()
        {
            throw new NotImplementedException();
        }
    }
}
