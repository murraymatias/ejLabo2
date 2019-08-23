using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Escribir un programa que imprima por pantalla una pirámide como
la siguiente:
*
***
*****
*******
*********
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
ejemplo anterior la altura ingresada fue de 5.
Nota: Utilizar estructuras repetitivas y selectivas
*/
namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string cadena = "*";

            Console.WriteLine("Ingrese altura de la piramide: ");
            altura = Convert.ToInt32(Console.ReadLine());

            if (altura > 0)
            {
                Console.WriteLine(cadena);
                for (int i = 0; i < altura; i++)
                {
                    cadena = cadena + "**";
                    Console.WriteLine(cadena);
                }
            }

            Console.ReadKey();
        }
    }
}
