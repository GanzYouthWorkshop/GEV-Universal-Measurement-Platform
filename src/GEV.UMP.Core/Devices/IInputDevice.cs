using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Devices
{
    public interface IInputDevice : IIODevice
    {
        void ReadValue(string value);
        void ReadValues(List<string> values);
        void ReadAllValues();
    }
}
