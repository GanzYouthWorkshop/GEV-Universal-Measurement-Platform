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
        public KeyedCollection<PLCVariable> Variables { get; } = new KeyedCollection<PLCVariable>(variable => variable.Name);
    }
}
