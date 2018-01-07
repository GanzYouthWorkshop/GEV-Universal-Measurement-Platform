using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GEV.UMP.Core.Data;

namespace GEV.UMP.Core.Devices
{
    public interface IIODevice
    {
        KeyedCollection<IOVariable> Values { get; }
    }
}
