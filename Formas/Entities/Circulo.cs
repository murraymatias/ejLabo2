using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public sealed class Circulo:Figura
    {
        private double radio;

        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public override string Dibujar()
        {
            return "Dibujando Circulo ...";
        }

        public override double CalcularPerimetro()
        {
            return this.radio * 2 * Math.PI; 
        }

        public override double CalcularSuperficie()
        {
            return Math.Pow(this.radio, 2) * Math.PI; 
        }
    }
}
