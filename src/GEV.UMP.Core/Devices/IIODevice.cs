using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Devices
{
    public interface IIODevice
    {
        Dictionary<string, object> Values { get; }
    }
}
