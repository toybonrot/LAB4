using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    class Circle : CircleLine
    {
        double squer { get; }
        public Circle() : base()
        {
            squer = 0;
        }
        public Circle(Point mp, double r) : base(mp, r)
        {
            squer = Math.PI * r * r;
        }
        public Circle(double x, double y, double r) : base(x, y, r)
        {
            squer = Math.PI * r * r;
        }
        public override string ToString()
        {
            Console.WriteLine("Circle:ToString");
            //return $"mp = ({mp.ToString()}), r = {r}, squer = {squer}";
            return base.ToString() + $", squer = {squer}";
        }
        public override bool Equals(object obj)
        {
            Console.WriteLine("Circle:Equals");
            if (obj == null)
            {
                return false;
            }
            if (obj is Circle)
            {
                Circle p = (Circle)obj;
                if (this.mp.Equals(p.mp) && this.r == p.r)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
