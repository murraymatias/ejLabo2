using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Rectangulo : Figura
    {
        protected double lado1;
        protected double lado2;

        public Rectangulo(double lado1,double lado2)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }
        public override string Dibujar()
        {
            return "Dibujando Rectangulo ...";
        }

        public override double CalcularPerimetro()
        {
            return this.lado1 * 2 + this.lado2 * 2;
        }

        public override double CalcularSuperficie()
        {
            return this.lado1 * this.lado2;
        }
    }
}
