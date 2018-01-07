using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data.Geometry
{
    public class Vector3 : Vector
    {
        public double X
        {
            get { return this.RawValues[0]; }
            set { this.RawValues[0] = value; }
        }

        public double Y
        {
            get { return this.RawValues[1]; }
            set { this.RawValues[1] = value; }
        }

        public double Z
        {
            get { return this.RawValues[2]; }
            set { this.RawValues[2] = value; }
        }


        public Vector3() : base(3)
        {

        }

        public Vector3(double X, double Y, double Z) : base(3)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public static implicit operator Vector3(Vector4 v)
        {
            return new Vector3(v.X, v.Y, v.Z);
        }
    }
}
