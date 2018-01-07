using GEV.UMP.Core.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Devices.IO.Automation
{
    public class PLCVariable<T> : IOVariable<T>
    {
        public PLCVariableUpdateMode UpdateMode { get; set; }
    }
}
