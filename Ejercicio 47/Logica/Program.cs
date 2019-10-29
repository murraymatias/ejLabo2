using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Genero equipos de prueba
            Equipo e1 = new EquipoBasquet("Lorem", new DateTime(2000, 01, 10));
            Equipo e2 = new EquipoBasquet("Ipsum", new DateTime(2001, 02, 10));
            EquipoBasquet e3 = new EquipoBasquet("Dolor", new DateTime(2002, 03, 10));
            EquipoBasquet e4 = new EquipoBasquet("Sit", new DateTime(2003, 04, 10));
            Equipo e5 = new EquipoFutbol("Amet", new DateTime(1945, 05, 10));
            Equipo e6 = new EquipoFutbol("consectetur", new DateTime(456, 04, 21));
            EquipoFutbol e7 = new EquipoFutbol("adipiscing", new DateTime(45, 10, 01));
            EquipoFutbol e8 = new EquipoFutbol("eiusmod", new DateTime(4562, 10, 01));
            EquipoBasquet e9 = new EquipoBasquet("incididunt", new DateTime(4657, 04, 30));
            EquipoFutbol e10 = new EquipoFutbol("architecto", new DateTime(1, 1, 1));

            //Creo un torneo de cada tipo
            Torneo<Equipo> torneoMixto = new Torneo<Equipo>();
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>();
            Torneo<EquipoBasquet> torneBasquet = new Torneo<EquipoBasquet>();


            torneoMixto += e1;
            torneoMixto += e2;
            torneoMixto += e3;
            torneoMixto += e4;
            torneoMixto += e5;
            torneoMixto += e6;
            torneoMixto += e7;
            torneoMixto += e8;
            torneoMixto += e9;
            torneoMixto += e10;
            torneoMixto += e10;

            torneoFutbol += e7;
            torneoFutbol += e8;
            torneoFutbol += e10;

            torneBasquet += e3;
            torneBasquet += e4;
            torneBasquet += e9;


            Console.WriteLine(torneoMixto.Mostrar());
            Console.WriteLine(torneBasquet.Mostrar());
            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine();

            Console.WriteLine(torneoMixto.JugarPartido);
            Console.ReadKey();
            Console.WriteLine(torneoMixto.JugarPartido);
            Console.ReadKey();
            Console.WriteLine(torneoMixto.JugarPartido);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.ReadKey();
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.ReadKey();
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine(torneBasquet.JugarPartido);
            Console.ReadKey();
            Console.WriteLine(torneBasquet.JugarPartido);
            Console.ReadKey();
            Console.WriteLine(torneBasquet.JugarPartido);


            Console.ReadKey();
        }
    }
}
