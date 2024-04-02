using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class CircleLine
    {
        protected Point mp { get; set; }
        protected double r { get; set; }

        public CircleLine()
        {
            mp = new Point();
            r = 0;
        }

        public CircleLine(Point mp, double r)
        {
            this.mp = mp;
            this.r = r;
        }

        public CircleLine(double x, double y, double r)
        {
            mp = new Point(x, y);
            this.r = r;
            Console.WriteLine("CircleLine:CircleLine(x, y, z)");
        }

        public double Length()
        {
            Console.WriteLine("CircleLine:Length");
            return 2 * Math.PI * r;
        }

        public override string ToString()
        {
            Console.WriteLine("CircleLine:ToString");
            return $"mp = ({mp.ToString()}), r = {r}";
        }

        public override bool Equals(object obj)
        {
            Console.WriteLine("CircleLine:Equals");
            if (obj == null)
            {
                return false;
            }
            if (obj is CircleLine)
            {
                CircleLine p = (CircleLine)obj;
                if (this.mp.Equals(p.mp) && this.r == p.r)
                {
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            Console.WriteLine("CircleLine:GetHashCode");
            int hc = 13;
            hc = (hc * 7) + mp.GetHashCode();
            hc = (hc * 7) + r.GetHashCode();
            return hc;
        }

        public bool Nalesh(Point p)
        {
            Console.WriteLine("CircleLine:Nalesh");
            double length = Math.Sqrt(Math.Pow(mp.x - p.x, 2) + Math.Pow(mp.y - p.y, 2));
            if (length == r)
            {
                return true;
            }
            return false;
        }

        public bool Nalesh(double x, double y)
        {
            Console.WriteLine("CircleLine:Nalesh");
            double length = Math.Sqrt(Math.Pow(mp.x - x, 2) + Math.Pow(mp.y - y, 2));
            if (length == r)
            {
                return true;
            }
            return false;
        }
    }
}
