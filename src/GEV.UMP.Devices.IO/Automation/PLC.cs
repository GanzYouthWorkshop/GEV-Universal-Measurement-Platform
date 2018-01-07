using GEV.UMP.Core.Devices;
using GEV.UMP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Devices.IO.Automation
{
    public class PLC  //: IInputDevice, IOutputDevice
    {
        public KeyedCollection<IOVariable> Variables { get; } = new KeyedCollection<IOVariable>(variable => variable.Name);
    }
}
