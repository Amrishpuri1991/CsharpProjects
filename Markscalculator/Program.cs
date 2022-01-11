using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Markscalculator
{
    class Calculator
    {
        
        public int Sbj1, sbj2, sbj3;

        internal void getMarksFromUser()
        {
            Console.Write("Enter your marks for first Subject : ");
            Sbj1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your marks for second Subject : ");
            sbj2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your marks for Third Subject : ");
            sbj3 = Convert.ToInt32(Console.ReadLine());

        }
        internal void sumOfSubjects()
        {
            Console.WriteLine();
            Console.WriteLine("************************************");
            Console.WriteLine("Sum of all three subject : " + (Sbj1 + sbj2+ sbj3));

        }

        internal void avgOfSubjects()
        {
            Console.WriteLine("Average of all three subject : " + (Sbj1 + sbj2 + sbj3)/3);
            Console.WriteLine("************************************");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Calculator _calculator = new Calculator();
            _calculator.getMarksFromUser();
           
            _calculator.sumOfSubjects();
            _calculator.avgOfSubjects();
            Console.Read();
        }
    }
}
