using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    class Figura : Producto
    {
        protected double altura;

        public Figura(int stock,double precio,double altura):base("Figura "+altura+" cm",stock,precio)
        {
            this.altura = altura;
        }

        public Figura(string descripcion,int stock,double precio,double altura):base(descripcion,stock,precio)
        {
            this.altura = altura;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            sb.AppendFormat("Altura: {0}\n", this.altura);

            return sb.ToString();
        }
    }
}
