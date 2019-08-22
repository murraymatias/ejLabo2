using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.*/
namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;

            Console.WriteLine("Ingrese su año de nacimiento: ");
            year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su mes de nacimiento: ");
            month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese su dia de nacimiento: ");
            day = Convert.ToInt32(Console.ReadLine());

            DateTime fechaNacimiento = new DateTime(year, month, day);

            DateTime fechaHoy = DateTime.Now;

            int resultado = (int)fechaHoy.Subtract(fechaNacimiento).TotalDays;

            Console.WriteLine("Usted tiene {0} dias de edad", resultado);

            Console.ReadKey();
        }
    }
}
