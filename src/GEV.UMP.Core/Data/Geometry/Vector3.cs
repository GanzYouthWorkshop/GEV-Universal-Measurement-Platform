using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data.Geometry
{
    public class Vector3 : Vector
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
        #endregion

        #region Konstruktorok
        public Vector3() : base(3)
        {
            this.X = 0;
            this.Y = 0;
            this.Z = 0;
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
        #endregion

        #region Operátorok
        public static Vector3 operator +(Vector3 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector3 operator +(Vector3 v1, Vector2 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v1.Z);
        }

        public static Vector3 operator +(Vector2 v1, Vector3 v2)
        {
            return new Vector3(v1.X + v2.X, v1.Y + v2.Y, v2.Z);
        }
        #endregion
    }
}
