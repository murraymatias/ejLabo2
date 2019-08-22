using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";

            int numero;

            Console.WriteLine("Ingrese un numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            bool esPrimo;
            for(int i = 0; i <= numero; i++)
            {
                esPrimo = true;
                for(int j = i-1; j > 1; j--)
                {
                    if(i % j == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
                if(esPrimo)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.ReadKey();
        }
    }
}
