using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*. Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
trabajadas en el mes de N empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
Nota: Utilizar estructuras repetitivas y selectivas
*/
namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            float valorHora;
            int antiguedad;
            int horasTrabajadas;
            float sueldoBruto;
            float sueldoNeto;
            float descuentos;
            char respuesta;

            do { 
                Console.WriteLine("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("Ingrese valor hora: ");
                valorHora = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Ingrese antiguedad: ");
                antiguedad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese horas trabajadas: ");
                horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                sueldoBruto = horasTrabajadas * valorHora + antiguedad * 150;
                descuentos = sueldoBruto * (float)0.13;
                sueldoNeto = sueldoBruto * (float)0.87;

                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Antiguedad: {0}", antiguedad);
                Console.WriteLine("Valor hora: {0}", valorHora);
                Console.WriteLine("Sueldo bruto: {0}", sueldoBruto);
                Console.WriteLine("Descuentos: {0}", descuentos);
                Console.WriteLine("Sueldo neto: {0}", sueldoNeto);
                Console.WriteLine();
                Console.WriteLine("Desea volver a calcular [S/N]:");
                respuesta = Convert.ToChar(Console.ReadLine());

            }while(respuesta == 'S');


        }
    }
}
