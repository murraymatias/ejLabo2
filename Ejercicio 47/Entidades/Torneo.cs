using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;

        public Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            if (torneo.equipos.Contains(equipo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {
            return !(torneo == equipo);
        }

        public static Torneo<T> operator +(Torneo<T> torneo, T equipo)
        {
            if(torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }

            return torneo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre del torneo: {0}\n", this.nombre);
            sb.AppendLine();
            sb.AppendLine("Participantes");

            foreach(T i in this.equipos)
            {
                sb.AppendFormat("{0} - {1}\n",i.Nombre,i.Fundacion);
            }

            return sb.ToString();
        }

        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random r = new Random();

            return String.Format("[{0}][{1}]-[{2}][{3}]", equipo1.Nombre, r.Next(0, 10), r.Next(0, 10), equipo2.Nombre);
        }

        public string JugarPartido
        {            
            get 
            { 
                Random r = new Random();
                return this.CalcularPartido(this.equipos[r.Next(0, this.equipos.Count)], this.equipos[r.Next(0, this.equipos.Count)]);
            }
        }
    }
}
