using GEV.UMP.ResultCalculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Configuration.Parameters
{
    public class Parameter
    {
        public string Name { get; set; }
        public bool IsQualifying { get; set; }
        public ResultCalculator Calculator { get; set; }
        public Tolerance Tolerance { get; set; }
        public Correction Correction { get; set; }
    }
}
