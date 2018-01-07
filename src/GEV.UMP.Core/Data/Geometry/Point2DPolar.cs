using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data.Geometry
{
    public class Point2DPolar
    {
        public double Length { get; set; }
        public double Angle { get; set; }

        public Point2DPolar(double Length, double Angle)
        {
            this.Length = Length;
            this.Angle = Angle;
        }

        public static implicit operator Point2DPolar(Point2D p)
        {
            double x = Math.Sqrt(p.X * p.X + p.Y * p.Y);
            double a = Math.Atan(p.Y / p.X);

            return new Point2DPolar(x, a);

        }
    }
}
