using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void descOrder(char[] s)
        {
            Array.Sort(s);
            reverse(s);
        }

        static void reverse(char[] a)
        {
            int i, n = a.Length;
            char t;
            for (i = 0; i < n / 2; i++)
            {
                t = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = t;
            }
        }
        static void Main(string[] args)
        {
            string charr;
           
            Console.WriteLine("Enter storing value : ");
            charr = Console.ReadLine();
            char[] s = charr.ToCharArray();
            descOrder(s); 
            Console.WriteLine(String.Join("", s));
            Console.Read();
        }
    }
}
