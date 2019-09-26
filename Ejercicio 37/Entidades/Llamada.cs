using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Duracion: {0}\n", this.duracion);
            sb.AppendFormat("Numero de origen: {0}\n", this.nroOrigen);
            sb.AppendFormat("Numero de destino: {0}\n", this.nroDestino);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.duracion == llamada2.duracion)
            {
                return 0;
            }
            else if (llamada1.duracion > llamada2.duracion)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
