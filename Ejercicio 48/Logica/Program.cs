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
            Contabilidad<Recibo, Factura> contabilidad = new Contabilidad<Recibo, Factura>();

            Recibo r1 = new Recibo(1);
            Recibo r2 = new Recibo(2);
            Recibo r3 = new Recibo(3);

            Factura f1 = new Factura(1);
            Factura f2 = new Factura(2);
            Factura f3 = new Factura(3);

            contabilidad += f1;
            contabilidad += f2;
            contabilidad += f3;

            contabilidad += r1;
            contabilidad += r2;
            contabilidad += r3;

            Console.WriteLine(contabilidad.ToString());

            Console.ReadKey();
        }
    }
}
