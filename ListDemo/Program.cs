using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDemo
{
    class Employee
    {
        public int empid { get; set; }
        public string fname { get; set; }
        public int salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();           
            li.Add(new Employee { empid=1, fname="Amrish", salary=36600 });
            li.Add(new Employee { empid=2, fname="Swati", salary=25100 });
            li.Add(new Employee { empid=3, fname="Ankit", salary=15000 });
            li.Add(new Employee { empid=4, fname="Raj", salary=6470 });

            foreach (var item in li)
            {
                Console.WriteLine("\nID: "+item.empid);
                Console.WriteLine("Name: "+item.fname);
                Console.WriteLine("Salary: "+item.salary);
            }

            Console.Read();
        }
    }
}
