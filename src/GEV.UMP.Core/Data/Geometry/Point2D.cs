using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEV.UMP.Core.Data.Geometry
{
    public class Point2D : Vector2
    {
        public Point2D(double x, double y) : base(x, y)
        {

        }

        public static implicit operator Point2D(Point2DPolar p)
        {
            double x = p.Length * Math.Cos(p.Angle);
            double y = p.Length * Math.Sin(p.Angle);

            return new Point2D(x, y);
        }
    }
}
