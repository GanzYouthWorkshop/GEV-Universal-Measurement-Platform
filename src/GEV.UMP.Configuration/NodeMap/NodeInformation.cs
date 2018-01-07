using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Configuration.NodeMap
{
    public class NodeInformation
    {
        public enum Types
        {
            Control,
            Compute
        }

        public string Address { get; set; }
        public Types Type { get; set; }
        public string Name { get; set; }
    }
}
