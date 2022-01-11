using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritances
{
    class Employee
    {
        int id;
        string name;
        protected void GetEmployees()
        {
            Console.Write("Enter Employee ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            name = Console.ReadLine();
        }
        protected void ShowEmployees()
        {
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
        }
    }
    class Payroll : Employee
    {
        int salary;
        internal void GetPayroll()
        {
            GetEmployees();
            Console.Write("Enter Employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        internal void ShowPayroll()
        {
            ShowEmployees();
            Console.WriteLine("Employee Salary: "+salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Payroll p = new Payroll();
            p.GetPayroll();
            p.ShowPayroll();

            Console.Read();

        }
    }
}
