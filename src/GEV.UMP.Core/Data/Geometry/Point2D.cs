using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data.Geometry
{
    public class Point2D : Vector2
    {
        #region Konstruktorok
        public Point2D(double x, double y) : base(x, y)
        {

        }

        public static implicit operator Point2D(Point2DPolar p)
        {
            double x = p.Radius * Math.Cos(p.Angle);
            double y = p.Radius * Math.Sin(p.Angle);

            return new Point2D(x, y);
        }
        #endregion

        public double DistanceTo(Point2D p)
        {
            return Math.Sqrt(Math.Pow(this.X - p.X, 2) + Math.Pow(this.Y - p.Y, 2));
        }
    }
}
