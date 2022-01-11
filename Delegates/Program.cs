using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void FirstDelegate();
    class Employee
    {
        internal void Display()
        {
            Console.WriteLine("Inside Display Method");
        }
        internal void Show()
        {
            Console.WriteLine("Inside Show Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            FirstDelegate del1 = new FirstDelegate(e.Display);
            //multicasting
            del1 += new FirstDelegate(e.Show);

            del1();

            del1 -= new FirstDelegate(e.Display);

            del1();
            Console.Read();
        }
    }
}
