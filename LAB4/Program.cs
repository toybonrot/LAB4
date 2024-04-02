using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point(1, 2);
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p1));
            Point p3 = new Point(1, 2);
            Console.WriteLine(p3.Equals(p2));
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
            CircleLine c1 = new CircleLine();
            CircleLine c2 = new CircleLine(p2, 4);
            CircleLine c3 = new CircleLine(1, 5, 3);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());
            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine(c2.Equals(c2));
            Console.WriteLine(c3.Equals(c1));
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
            Console.WriteLine(c3.GetHashCode());
            Console.WriteLine(c1.Nalesh(p1));
            Console.WriteLine(c2.Nalesh(p1));
            Console.WriteLine(c3.Nalesh(1, 2));
            Console.WriteLine(c3.Nalesh(2, 2));
            Circle circle = new Circle();
            Circle circle2 = new Circle(p2, 3);
            Circle circle3 = new Circle(3, 1, 4);
            Console.WriteLine(circle.ToString());
            Console.WriteLine(circle2.ToString());
            Console.WriteLine(circle3.ToString());
            Console.WriteLine(circle2.Length());
            Console.WriteLine(circle3.Equals(circle));
            Console.WriteLine(circle2.GetHashCode());
            Console.ReadKey();
        }
    }
}
