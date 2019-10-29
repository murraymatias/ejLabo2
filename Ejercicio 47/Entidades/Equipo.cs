using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        public string Fundacion
        {
            get { return this.fechaCreacion.ToString(); }
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if(e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
    }
}
