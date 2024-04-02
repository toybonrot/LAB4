using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            Console.WriteLine("Point:ToString");
            return $"x = {x}, y = {y}";
        }

        public override int GetHashCode()
        {
            Console.WriteLine("Point:GetHashCode");
            int hc = 13;
            hc = (hc * 7) + x.GetHashCode();
            hc = (hc * 7) + y.GetHashCode();
            return hc;
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine("Point:Equals");
            if (obj == null)
            {
                return false;
            }
            if (obj is Point)
            {
                Point p = (Point)obj;
                if (this.x == p.x && this.y == p.y)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
