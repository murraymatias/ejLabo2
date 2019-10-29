using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Cuadrado:Rectangulo
    {

        public Cuadrado(double lado) : base(lado, lado) { }
/*
        public override double CalcularPerimetro()
        {
            return base.CalcularPeriometro();
        }

        public override double CalcularSuperficie()
        {
            return base.CalcularSuperficie();
        }
 */
    }
}
