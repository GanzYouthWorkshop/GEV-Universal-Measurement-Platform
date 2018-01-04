using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Devices.IO.Automation
{
    public class PLCVariable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public object Value { get; set; }
        public bool HasChanged { get; set; }
    }
}
