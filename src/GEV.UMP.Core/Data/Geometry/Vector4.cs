using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data.Geometry
{
    public class Vector4 : Vector
    {
        #region Mezők
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

        public double T
        {
            get { return this.RawValues[3]; }
            set { this.RawValues[3] = value; }
        }
        #endregion

        #region Konstruktorok
        public Vector4() : base(4)
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
            this.T = 0;
        }

        public Vector4(double X, double Y, double Z) : base(4)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.T = T;
        }
        #endregion
    }
}
