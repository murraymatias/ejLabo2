using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial:Llamada
    {
        protected Franja franjaHoraria;

        public Provincial(Franja franja,Llamada llamada) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = franja;
        }

        public Provincial(string nroOrigen, Franja franja, float duracion,string nroDestino): base(duracion, nroDestino, nroOrigen)
        {
            this.franjaHoraria = franja;
        }

        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return this.duracion * (float)0.99;
                case Franja.Franja_2:
                    return this.duracion * (float)1.25;
                case Franja.Franja_3:
                    return this.duracion * (float)0.66;
                default:
                    return this.duracion;
            }
        }

        public override bool Equals(object obj)
        {
            if (typeof(Provincial) == obj.GetType())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendFormat("Costo de la llamada: {0}\n", this.CostoLlamada);
            sb.AppendFormat("Franja horaria: {0}\n", this.franjaHoraria);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
