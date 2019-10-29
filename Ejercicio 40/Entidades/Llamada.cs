using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Llamada
    {
        #region Atributos

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        #endregion

        #region Propiedades
        public abstract float CostoLlamada
        {
            get;
        }

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
        #endregion

        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Operadores
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            if(l1.Equals(l2) && 
                l1.Duracion == l2.Duracion &&
                l1.NroDestino == l2.NroDestino &&
                l1.NroOrigen == l2.NroOrigen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion

        #region MetodosProtegidos
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Duracion: {0}\n", this.duracion);
            sb.AppendFormat("Numero de origen: {0}\n", this.nroOrigen);
            sb.AppendFormat("Numero de destino: {0}\n", this.nroDestino);

            return sb.ToString();
        }
        #endregion

        #region MetodosPublicos
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
        #endregion

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
    }
}
