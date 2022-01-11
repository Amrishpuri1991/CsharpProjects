using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritance
{
    class Perosn
    {
        string name;
        int age;
        protected void getPersonDetails()
        {
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
        protected void showPersonDetails()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class Student : Perosn
    {
        double Percentage;

        internal void GetStudentDetails()
        {
            getPersonDetails();
            Console.Write("Enter Percentage of student: ");
            Percentage = Convert.ToDouble(Console.ReadLine());
        }
        internal void ShowStudentDetails()
        {
            showPersonDetails();
            Console.WriteLine("Percentage of student is : " + Percentage+"%");
        }
    }

    class Teacher : Perosn
    {
        double salary;
        internal void GetTeacherDetails()
        {
            getPersonDetails();
            Console.Write("Enter salary of teacher: ");
            salary = Convert.ToDouble(Console.ReadLine());
        }
        internal void ShowTeacherDetails()
        {
            showPersonDetails();
            Console.Write("salary of teacher is : " + salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetStudentDetails();
            s1.ShowStudentDetails();

            Teacher t1 = new Teacher();
            t1.GetTeacherDetails();
            t1.ShowTeacherDetails();
            Console.Read();
        }
    }
}
