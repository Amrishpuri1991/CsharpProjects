using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    public class Employee
    {
        private int id;
        string name;
        internal void GetEmployees()
        {
            Console.Write("Enter Employee ID:");
            id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name:");
            name = Console.ReadLine();
        }
        internal void ShowEmployees()
        {
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.GetEmployees();          
            
            Console.WriteLine("\nEmployee Details:\n");
            emp.ShowEmployees();

            Console.Read();
        }
    }
}
