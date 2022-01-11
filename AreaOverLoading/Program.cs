using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOverLoading
{
    class CalculateArea
    {

        internal void area(double r)
        {
            Console.WriteLine("Area of Circle: " + (3.14 * r * r));
        }

        internal void area(int l, int b)
        {
            Console.WriteLine("Area of Rectangle: " + (l * b));
        }
        internal void area(double b, double h)
        {
            Console.WriteLine("Area of Triangle: " + (0.5 * b * h));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CalculateArea _calculate = new CalculateArea();
            _calculate.area(5.2);
            _calculate.area(5,2);
            _calculate.area(5.2,2.2);
            Console.Read();

        }
    }
}
