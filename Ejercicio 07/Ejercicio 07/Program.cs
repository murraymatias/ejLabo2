using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.
*/
namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            int thisYear, thisMonth, thisDay;
            int cuentaDias=0;

            Console.WriteLine("Ingrese su año de nacimiento: ");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su mes de nacimiento: ");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su dia de nacimiento: ");
            day = Convert.ToInt32(Console.ReadLine());

            thisYear = (int)DateTime.Now.Year;
            thisMonth = (int)DateTime.Now.Month;
            thisDay = (int)DateTime.Now.Day;

            for(int i = year; i<thisYear; i++)
            {
                if(isBisiesto(year))
                {
                    cuentaDias += 366;
                }
                else
                {
                    cuentaDias += 365;
                }
            }


            Console.ReadKey();
        }

        private static bool isBisiesto(int year)
        {
            bool isBisiesto = false;
            if (year % 4 == 0)
            {
                //Comprueba que no sea multiplo de 100.
                if (year % 100 != 0)
                {
                    isBisiesto = true;
                }
                else
                {
                    //Si es multiplo de 100, prueba que tambien lo sea de 400.
                    if (year % 400 == 0)
                    {
                        isBisiesto = true;
                    }
                }
            }
            return isBisiesto;
        }
    }
}
