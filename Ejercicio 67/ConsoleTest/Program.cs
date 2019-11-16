using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Entities;

namespace ConsoleTest
{
    class Program
    {
        public static void ImprimeDTNow()
        {
            Console.WriteLine(DateTime.Now);
        }        

        static void Main(string[] args)
        {
            Temporizador temporizador = new Temporizador();
            temporizador.Intervalo = 1000;
            temporizador.EventoTiempo += ImprimeDTNow;

            Console.ReadKey();

            temporizador.Activo = true;

            Console.ReadKey();

            temporizador.Activo = false;

            Console.ReadKey();
        }     

    }
}
