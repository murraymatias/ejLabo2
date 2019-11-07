using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "Lorem ipsum dolor sit amet";

            Console.WriteLine("cantidad de palabras = {0}",test.ContarPalabras());

            Console.ReadKey();
        }
    }
}
