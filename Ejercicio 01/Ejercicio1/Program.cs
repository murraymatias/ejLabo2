using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";
            int numero;
            double acumulador = 0;
            int max = 0;
            int min = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero:");
                numero = Convert.ToInt32(Console.ReadLine());

                acumulador += numero;

                if(i==0 || numero>max)
                {
                    max = numero;
                }

                if(i==0 || numero<min)
                {
                    min = numero;
                }
            }
            Console.Clear();
            Console.WriteLine("Minimo: {0}", min);
            Console.WriteLine("Maximo: {0}", max);
            Console.WriteLine("Promedio: {0}", acumulador/5);
            Console.ReadKey();
        }
    }
}
