using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data.Geometry
{
    public class Vector2 : Vector
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

        public Vector2() : base(2)
        {

        }

        public Vector2(double X, double Y) : base(2)
        {
            this.X = X;
            this.Y = Y;
        }

        public static implicit operator Vector2(Vector3 v)
        {
            return new Vector2(v.X, v.Y);
        }
    }
}
