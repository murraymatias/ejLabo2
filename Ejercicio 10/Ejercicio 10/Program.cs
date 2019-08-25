using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels;
            string step = "*";

            Console.WriteLine("Ingrese el numero de niveles:");
            levels = Convert.ToInt32(Console.ReadLine());

            for (int i = levels; i>0; i--)
            {
                Console.WriteLine(Indent(i) + step);
                step = step + "**";
            }

            Console.ReadKey();
        }

        public static string Indent(int count)
        {
            return "".PadLeft(count);
        }
    }
}
