using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data.Geometry
{
    public class Point2DPolar
    {
        #region Mezők
        public double Radius { get; set; }
        public double Angle { get; set; }
        #endregion

        #region Konstruktorok
        public Point2DPolar(double radius, double angle)
        {
            this.Radius = radius;
            this.Angle = angle;
        }

        public static implicit operator Point2DPolar(Point2D p)
        {
            double x = Math.Sqrt(p.X * p.X + p.Y * p.Y);
            double a = Math.Atan(p.Y / p.X);

            return new Point2DPolar(x, a);

        }
        #endregion

        public double DistanceTo(Point2DPolar p)
        {
            return Math.Sqrt(this.Radius * this.Radius + p.Radius * p.Radius - 2 * this.Radius * p.Radius * Math.Cos(this.Angle - p.Angle));
        }
    }
}
