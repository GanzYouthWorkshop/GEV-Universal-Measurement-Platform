using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Devices
{
    public abstract class IOVariable : IIOVariable
    {
        public string Address { get; set; }
        public bool HasChanged { get; set; }
        public string Name { get; set; }

        public abstract Type ValueType { get; set; }
    }

    public class IOVariable<T> : IOVariable
    {
        public T Value { get; set; }
        public override Type ValueType { get; set; } = typeof(T);
    }
}
