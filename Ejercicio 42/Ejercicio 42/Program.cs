using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_42
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase2 miClase = new MiClase2();

            try
            {
                miClase.MetodoInstancia();
            }
            catch(Exception e)
            {
                Exception e1 = e;
                do
                {
                    Console.WriteLine("{0},{1}", e1.Message, e1.GetType().ToString());
                    e1 = e1.InnerException;

                } while (e1 != null);
                Console.WriteLine();
                Console.WriteLine();
                e1 = e;
                do
                {
                    Console.WriteLine(e1.StackTrace);
                    e1 = e1.InnerException;
                } while (e1 != null);
            }

            Console.ReadKey();
        }
    }
}
