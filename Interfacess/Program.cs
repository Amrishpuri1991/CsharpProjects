﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    interface IEmployee
    {
        void GetEmployee();
        void ShowEmployee();
    }
    class Employee : IEmployee
    {
        public void GetEmployee()
        {
            Console.WriteLine("Calling Get Method");
        }

        public void ShowEmployee()
        {
            Console.WriteLine("Calling Show Method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee obj = new Employee();
            obj.GetEmployee();
            obj.ShowEmployee();

            Console.Read();
        }
    }
}
