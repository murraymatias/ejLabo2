using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForms
{
    class Persona
    {
        private string apellido;
        private string nombre;

        public string Apellido
        {
            get { return this.apellido; }
            set { if (value != this.apellido)
                {
                    this.apellido = value;
                    if(EventoString != null)
                    {
                        EventoString.Invoke("Se modifico el apelido.");
                    }
                }
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { if (value != this.nombre) 
                {
                    this.nombre = value;
                    if (EventoString != null)
                    {
                        EventoString.Invoke("Se Modifico el nombre");
                    }
                }
            }
        }

        public Persona()
        {
            this.apellido = string.Empty;
            this.nombre = string.Empty;            
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n",this.Nombre);
            sb.AppendFormat("Apellido: {0}\n", this.Apellido);
            return sb.ToString();
        }

        public event DelegadoString EventoString;
    }

    public delegate void DelegadoString(string msg);
}
