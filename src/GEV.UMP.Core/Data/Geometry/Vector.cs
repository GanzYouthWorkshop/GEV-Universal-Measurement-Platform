using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data.Geometry
{
    public class Vector
    {
        public double[] RawValues { get; }

        public double VectorLength
        {
            get
            {
                double sum = 0;
                foreach(double d in this.RawValues)
                {
                    sum += d * d;
                }
                return Math.Sqrt(sum);
            }
        }

        public Vector(int size)
        {
            this.RawValues = new double[size];
        }
    }
}
