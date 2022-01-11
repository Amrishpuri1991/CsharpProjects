using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceSpecificCharacter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the string : ");
            string str = Console.ReadLine();
            Console.Write("Enter the Charcter to be removed : ");
            //char needed to be removed from string
            char removeChar = Convert.ToChar(Console.ReadLine());
            // finding the index of the charcater to be removed
            int index = str.IndexOf(removeChar);

            while (index != -1)
            {
                str = str.Remove(index, 1);

                index = str.IndexOf(removeChar);
            }

            Console.WriteLine("Character Removed : " + str);

            Console.Read();
        }
    }
}
