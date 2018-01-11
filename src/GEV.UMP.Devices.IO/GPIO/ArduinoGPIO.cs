using GEV.UMP.Core.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEV.UMP.Core.Data;
using GEV.UMP.Utils;

namespace GEV.UMP.Devices.IO.GPIO
{
    public class ArduinoGPIO : SerialDevice, IInputDevice, IOutputDevice
    {
        public KeyedCollection<IOVariable> Values { get; } = new KeyedCollection<IOVariable>(item => item.Name)
        {
            new IOVariable<bool>() { Address = "1", Name = "Pin 1", Value = false }
        };

        public override bool Open()
        {
            bool b = base.Open();


        }

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
