﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Devices
{
    public interface IOutputDevice : IIODevice
    {
        void WriteValue(string name, object value);
        void WriteValues();
    }
}
