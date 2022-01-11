
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overridings
{
    abstract class Employee
    {
        virtual public void display()
        {
            Console.WriteLine("From Employee Class");
        }
    }
    class Payroll : Employee
    {
        override public void display()
        {
            Console.WriteLine("From Payroll class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Payroll();
            p.display();

            Console.Read();
        }
    }
}
