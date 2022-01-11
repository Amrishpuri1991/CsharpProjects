using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'o';
            switch (ch)
            {
                case 'a':
                    
                case 'e':
                    
                case 'i':
                    
                case 'o':
                    
                case 'u':
                    Console.WriteLine("{0} ia a Vowel", ch);
                    break;

                default:
                    Console.WriteLine("{0} ia a Consonent", ch);
                    break;
            }
            Console.Read();
        }
    }
}
