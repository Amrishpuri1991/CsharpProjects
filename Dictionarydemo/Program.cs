using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionarydemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // name:Amrish
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("ID",101);
            dic.Add("Name","Amrish");
            dic.Add("Salary",36500.5);
            dic.Add("Gender",'M');

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key+" : "+item.Value);
            }

            Console.Read();
        }
    }
}
