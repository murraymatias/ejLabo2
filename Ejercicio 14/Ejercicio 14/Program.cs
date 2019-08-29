using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main().
*/
namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            double numero1;
            double numero2;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Calcular area de un cuadrado");
                Console.WriteLine("2. Calcular area de un triangulo");
                Console.WriteLine("3. Calcular area de un circulo");

                while (!Int32.TryParse(Console.ReadLine(), out option) || option > 3 || option < 1)
                {
                    Console.WriteLine("Ingrese una opcion valida");
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Ingrese el lado del cuadrado: ");
                        while (!double.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Ingrese un valor valido");
                        }
                        Console.WriteLine("El area es: {0}", CalculoDeArea.CalcularCuadrado(numero1));
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la base del triangulo: ");
                        while (!double.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Ingrese un valor valido");
                        }
                        Console.WriteLine("Ingrese la altura del triangulo: ");
                        while (!double.TryParse(Console.ReadLine(), out numero2))
                        {
                            Console.WriteLine("Ingrese un valor valido");
                        }
                        Console.WriteLine("El area es: {0}", CalculoDeArea.CalcularTriangulo(numero1, numero2));
                        break;
                    case 3:
                        Console.WriteLine("Ingrese radio del circulo: ");
                        while (!double.TryParse(Console.ReadLine(), out numero1))
                        {
                            Console.WriteLine("Ingrese un valor valido");
                        }
                        Console.WriteLine("El area es: {0}", CalculoDeArea.CalcularCirculo(numero1));
                        break;

                }
                Console.WriteLine("");
                Console.WriteLine("Presione R para reiniciar");

            } while (Console.ReadKey().KeyChar=='r');
        }
    }
}
