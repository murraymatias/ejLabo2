using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Contructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region MetodosPrivados

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLlamadas.Add(nuevaLlamada);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**************************************************");
            sb.AppendFormat("Razon social: {0}\n", this.razonSocial);
            sb.AppendFormat("Ganancia total: {0}\n", this.GananciasPorTotal);
            sb.AppendFormat("Ganancia por local: {0}\n", this.GananciasPorLocal);
            sb.AppendFormat("Ganancia por provincial: {0}\n", this.GananciasPorProvincial);
            sb.AppendLine("////////////////////////////////////////////////////");
            sb.AppendLine("LLamadas realizadas:");

            foreach (Llamada llamada in listaDeLlamadas)
            {
                sb.AppendLine("------------------------------------------------");
                sb.Append(llamada.ToString());
                sb.AppendLine("------------------------------------------------");
            }
            sb.AppendLine("**************************************************");

            return sb.ToString();
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia=0;

            if(tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
            {
                foreach(Llamada llamada in listaDeLlamadas)
                {
                    if(llamada is Provincial)
                    {
                        ganancia += llamada.CostoLlamada;
                    }
                }
            }

            if(tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
            {
                foreach(Llamada llamada in listaDeLlamadas)
                {
                    if(llamada is Local)
                    {
                        ganancia += llamada.CostoLlamada;
                    }
                }
            }

            return ganancia;
        }
        #endregion

        #region Operadores

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach(Llamada l1 in c.Llamadas)
            {
                if (l1 == llamada)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c.Llamadas.Contains(nuevaLlamada))
            {
                throw new CentralitaException("La llamada ya existe", "Centralita", "Operador suma");
            }

            c.AgregarLlamada(nuevaLlamada);            
            return c;
        }

        #endregion

        #region MetodosPublicos

        public void OrdenarLlamadas()
        {
            IEnumerable<Llamada> llamadasOrdenadas = this.listaDeLlamadas.OrderBy(llamada => llamada.Duracion);
            this.listaDeLlamadas = llamadasOrdenadas.ToList();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}
