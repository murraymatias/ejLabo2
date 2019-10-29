using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Contabilidad<T, U> where T : Documento where U : Documento

    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }
         public static Contabilidad<T,U> operator +(Contabilidad<T,U> contabilidad,T egreso)
        {
            contabilidad.egresos.Add(egreso);

            return contabilidad;
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> contabilidad, U ingreso)
        {
            contabilidad.ingresos.Add(ingreso);

            return contabilidad;
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            s.AppendLine();
            s.AppendLine("Egresos");
            foreach(T i in egresos)
            {
                s.AppendLine(i.ToString());
            }

            s.AppendLine();
            s.AppendLine("Ingresos");
            foreach(U i in ingresos)
            {
                s.AppendLine(i.ToString());
            }

            return s.ToString();
        }
    }
}
