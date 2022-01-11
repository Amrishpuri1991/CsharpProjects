using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 50;
            if (a>50)
            {
                Console.WriteLine("A is Greater");
            }
            else if(a<50)
            {
                Console.WriteLine("A is Lesser");
            }
            else if(a==50)
            {
                Console.WriteLine("A is Equal");
            }

            Console.Read();
        }
    }
}
