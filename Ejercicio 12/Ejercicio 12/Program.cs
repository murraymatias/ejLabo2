using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor.
*/
namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            int acumulador = 0;
            do
            {
                Console.WriteLine("Ingrese un numero entero: ");
                if (Int32.TryParse(Console.ReadLine(), out valor))
                {
                    acumulador += valor;
                }
                Console.WriteLine("¿Continuar? (S/N)");
            } while (ValidarRespuesta.ValidaS_N(char.Parse(Console.ReadLine())));

            Console.WriteLine("Valor acumulado: {0}", acumulador);
            Console.ReadKey();
        }
    }
}
