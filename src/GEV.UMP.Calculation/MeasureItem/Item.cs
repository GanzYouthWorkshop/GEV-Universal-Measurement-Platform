using GEV.UMP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Calculation.MeasureItem
{
    public class Item
    {
        public ulong ID { get; set; }
        public KeyedCollection<ItemResult> Results { get; } = new KeyedCollection<ItemResult>(item => item.ParameterName);
    }
}
