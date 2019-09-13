using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("39950258", "Devy");
            dict.Add("13193115", "Philly");
            dict.Add("11131931", "Marleah");
            dict.Add("08024209", "Gianna");
            dict.Add("16711231", "Brigitta");

            foreach(KeyValuePair<string,string> item in dict)
            {
                Console.WriteLine("DNI: {0} Nombre: {1}",item.Key,item.Value);
            }

            Console.ReadKey();
        }
    }
}
