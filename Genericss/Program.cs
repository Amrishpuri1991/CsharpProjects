using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericss
{
    class Employee<Type1,Type2>
    {
        Type1 id;
        Type2 name;
        public Employee(Type1 i,Type2 n)
        {
            id = i;
            name = n;
        }

        internal void Display()
        {
            Console.WriteLine("Value of Type 1: "+id);
            Console.WriteLine("Value of Type 2: "+name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee<int, string> e1 = new Employee<int, string>(205,"Amrish");
            e1.Display();

            Employee<string,DateTime> e2 = new Employee<string, DateTime>("Amrish",DateTime.Now);
            e2.Display();

            Console.Read();
        }
    }
}
