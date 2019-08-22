using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas y selectivas.*/
namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int foundNumbers=0;
            int divisorsSum;

            //Itera hasta encontrar 4 numeros.
            for(int i = 0;foundNumbers<4;i++)
            {
                //Inicializa el acumulador de divisores en 0.
                divisorsSum = 0;
                //Itera todos los numeros positivos menores al indice.
                for(int j = i-1;j>0;j--)
                {
                    //Prueba si es divisor de i.
                    if(i % j == 0)
                    {
                        //Si es divisor lo suma al acumulador.
                        divisorsSum += j;
                    }
                }
                //Prueba si los divisores acumulados es igual al numero.
                if(divisorsSum==i)
                {
                    //Imprime el numero y aumenta el contador de numeros encontrados.
                    Console.WriteLine("Numero perfecto: {0}", i);
                    foundNumbers++;
                }
            }

            Console.ReadKey();
        }
    }
}
