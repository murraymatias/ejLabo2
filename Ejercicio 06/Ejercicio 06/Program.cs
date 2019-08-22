using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/
namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int initYear, endYear;

            Console.WriteLine("Ingrese año de inicio: ");
            initYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese año de finalizacion: ");
            endYear = Convert.ToInt32(Console.ReadLine());

            //Itera por todos los numeros enteros entre los valores ingresados.
            for (int i = initYear; i<=endYear; i++)
            {
                //Prueba si es multiplo de 4.
                if(i % 4 == 0)
                {
                    //Comprueba que no sea multiplo de 100.
                    if(i % 100 != 0)
                    {
                        Console.WriteLine("El año {0} es bisiesto.", i);
                    }
                    else
                    {
                        //Si es multiplo de 100, prueba que tambien lo sea de 400.
                        if(i % 400 == 0)
                        {
                            Console.WriteLine("El año {0} es bisiesto.", i);
                        }
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
