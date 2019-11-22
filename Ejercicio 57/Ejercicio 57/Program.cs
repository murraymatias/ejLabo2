using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Ejercicio_57
{
    class Program
    {
        private const string FILE_NAME = "data";
        static void Main(string[] args)
        { 
            Persona p1 = new Persona("Lorem","Ipsum");

            try
            {
                Persona.Guardar(p1, Environment.CurrentDirectory,FILE_NAME);
            }
            catch(Exception exception)
            {
                Console.Write(exception);
            }

            try
            {
                Persona p2 = Persona.Leer(Environment.CurrentDirectory +"\\"+ FILE_NAME + ".xml");
                Console.WriteLine(p2.ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
           

            Console.ReadKey();
        }
    }
}
