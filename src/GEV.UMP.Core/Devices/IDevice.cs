using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Devices
{
    public interface IDevice : IComponent
    {
        string Address { get; set; }

        bool Open();
        void Close();

    }
}
