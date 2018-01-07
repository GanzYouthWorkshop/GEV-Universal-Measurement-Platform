using GEV.UMP.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core
{
    public interface IComponent
    {
        string Name { get; set; }
        ComponentStatus Status { get; }

        List<StatusMessage> StatusMessages { get; }
    }
}
