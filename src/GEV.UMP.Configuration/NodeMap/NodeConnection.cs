﻿using GEV.UMP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Configuration.NodeMap
{
    public class NodeConnection
    {
        public IComponent Input { get; set; }
        public IComponent Output { get; set; }
    }
}
