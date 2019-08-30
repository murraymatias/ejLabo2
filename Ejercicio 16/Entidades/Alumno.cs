using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }   

        public void CalcularFinal()
        {
            if(this.nota1>=4 && this.nota2>=4)
            {
                Random rnd = new Random();
                this.notaFinal = rnd.Next(1, 11);
            }
            else
            {
                this.notaFinal = -1;
            }
        }
        
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
            string ret = String.Format(
                    "Legajo: {0}\n" +
                    "Nombre: {1}\n" +
                    "Apellido: {2}\n" +
                    "Nota1: {3}\n" +
                    "Nota2: {4}\n" +
                    "Nota Final: ", this.legajo, this.nombre, this.apellido, this.nota1, this.nota2);

            if (this.notaFinal != -1)
            {
                ret += Convert.ToString(this.notaFinal)+"\n";
            }
            else
            {
                ret += "Alumno desaprobado\n";
            }
                return ret;
        }
    }
}
