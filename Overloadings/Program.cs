using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloadings
{
    class Shape
    {
        internal void area(double r)
        {
            Console.WriteLine("Area of Circle: " + (3.14 * r * r));
        }
        internal void area(int a)
        {
            Console.WriteLine("Area of Square: "+(a*a));
        }
        internal void area(int l,int b)
        {
            Console.WriteLine("Area of Rectangle: "+(l*b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.area(10.5);
            s.area(10);
            s.area(10,5);

            Console.Read();
        }
    }
}
