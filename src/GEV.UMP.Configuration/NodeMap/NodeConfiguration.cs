using GEV.UMP.Core;
using GEV.UMP.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Configuration.NodeMap
{
    public class NodeConfiguration
    {
        public KeyedCollection<IComponent> Components { get; } = new KeyedCollection<IComponent>(item => item.Name);
        public List<NodeConnection> Connections { get; } = new List<NodeConnection>();
    }
}
