using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string apellido;
        private string dni;
        private DateTime fechaNacimiento;
        private List<Mascota> listaMascotas;

        public Cliente(int id,string nombre,string apellido,string dni,DateTime? fechaNacimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = (DateTime)fechaNacimiento;
        }

        public int ID
        {
            set => id = value;
            get => id;
        }

        public string Nombre
        {
            set => nombre = value;
            get => nombre;
        }

        public string Apellido
        {
            set => apellido = value;
            get => apellido;
        }

        public string DNI
        {
            set => dni = value;
            get => dni;
        }

        public DateTime FechaNacimiento
        {
            set => fechaNacimiento = value;
            get => fechaNacimiento;
        }

        public List<Mascota> Mascotas
        {
            set => listaMascotas = value;
            get => listaMascotas;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("id:{0}\n", this.id);
            sb.AppendFormat("nombre:{0}\n", this.nombre);
            sb.AppendFormat("apellido:{0}\n", this.apellido);
            sb.AppendFormat("dni:{0}\n", this.dni);

            return sb.ToString();
        }
    }
}
