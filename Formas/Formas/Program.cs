using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Formas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();


            lista.Add(new Circulo(2));
            lista.Add(new Cuadrado(3));
            lista.Add(new Rectangulo(4, 8));

            StringBuilder sb = new StringBuilder();

            int i = 1;
            foreach (Figura figura in lista)
            {               
                sb.AppendFormat("================ FIGURA {0:00} ==================\n",i);
                sb.AppendFormat("Tipo: {0}\n", figura.GetType());
                sb.AppendLine(figura.Dibujar());
                sb.AppendFormat("Area: {0:0.00}\n", figura.CalcularSuperficie());
                sb.AppendFormat("Perimetro: {0:0.00}\n",figura.CalcularPerimetro());
                sb.AppendLine("=============================================\n");
                i++;
            }

            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}
