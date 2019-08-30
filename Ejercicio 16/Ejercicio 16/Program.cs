using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Lorem", "Sit", 1);
            alumno1.Estudiar(6, 3);
            alumno1.CalcularFinal();
            Console.WriteLine(alumno1.Mostrar());

            Alumno alumno2 = new Alumno("Ipsum", "Amet", 2);
            alumno2.Estudiar(4, 4);
            alumno2.CalcularFinal();
            Console.WriteLine(alumno2.Mostrar());

            Alumno alumno3 = new Alumno("Dolor", "Consectetur", 3);
            alumno3.Estudiar(6, 6);
            alumno3.CalcularFinal();
            Console.WriteLine(alumno3.Mostrar());

            Console.ReadKey();
        }
    }
}
