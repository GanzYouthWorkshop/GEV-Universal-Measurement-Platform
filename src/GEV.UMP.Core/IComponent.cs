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

        //TODO: [KG] Kéne neki rendes information class
        string StatusMessages { get; }
    }
}
