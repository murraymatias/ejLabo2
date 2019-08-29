using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double side)
        {
            return Math.Pow(side, 2);
        }
        public static double CalcularTriangulo(double bottom, double height)
        {
            return (bottom * height) / 2;
        }
        public static double CalcularCirculo(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
