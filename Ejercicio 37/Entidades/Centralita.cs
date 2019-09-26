using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

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

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia=0;

            if(tipo == Llamada.TipoLlamada.Provincial || tipo == Llamada.TipoLlamada.Todas)
            {
                foreach(Llamada llamada in listaDeLlamadas)
                {
                    if(llamada is Provincial)
                    {
                        ganancia += ((Provincial)llamada).CostoLLamada;
                    }
                }
            }

            if(tipo == Llamada.TipoLlamada.Local || tipo == Llamada.TipoLlamada.Todas)
            {
                foreach(Llamada llamada in listaDeLlamadas)
                {
                    if(llamada is Local)
                    {
                        ganancia += ((Local)llamada).CostoLlamada;
                    }
                }
            }

            return ganancia;
        }

        public void OrdenarLlamadas()
        {
            IEnumerable<Llamada> llamadasOrdenadas = this.listaDeLlamadas.OrderBy(llamada => llamada.Duracion);
            this.listaDeLlamadas = llamadasOrdenadas.ToList();
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**************************************************");
            sb.AppendFormat("Razon social: {0}\n", this.razonSocial);
            sb.AppendFormat("Ganancia total: {0}\n", this.GananciasPorTotal);
            sb.AppendFormat("Ganancia por local: {0}\n", this.GananciasPorLocal);
            sb.AppendFormat("Ganancia por provincial: {0}\n", this.GananciasPorProvincial);
            sb.AppendLine("////////////////////////////////////////////////////");
            sb.AppendLine("LLamadas realizadas:");
            
            foreach(Llamada llamada in listaDeLlamadas)
            {
                sb.AppendLine("------------------------------------------------");
                sb.Append(llamada.Mostrar());
                sb.AppendLine("------------------------------------------------");
            }
            sb.AppendLine("**************************************************");

            return sb.ToString();
        }
    }
}
