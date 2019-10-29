using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro();

            for(int i = 0; i < 5; i++)
            {
                libro[i] = String.Format("Pagina {0:0}", i);
            }
        }
    }
}
