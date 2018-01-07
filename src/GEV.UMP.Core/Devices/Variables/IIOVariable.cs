using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Devices
{
    public interface IIOVariable
    {
        string Name { get; set; }
        string Address { get; set; }
        Type ValueType { get; set; }
        bool HasChanged { get; set; }
    }

    public interface IIOVariable<T> : IIOVariable
    {
        T Value { get; set; }
    }
}
