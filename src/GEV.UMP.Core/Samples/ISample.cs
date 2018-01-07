﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Samples
{
    public interface ISample
    {
        ulong ItemID { get; set; }
        List<ISampleUnit> Items { get; }
    }
}
