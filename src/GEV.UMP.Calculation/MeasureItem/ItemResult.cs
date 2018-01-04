using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Calculation.MeasureItem
{
    public class ItemResult
    {
        public string ParameterName { get; set; }
        public bool Valid { get; set; }

        public bool IsOK { get; set; }
        public bool IsOKWithCorrection { get; set; }

        public string DisplayResult { get; set; }
    }
}
