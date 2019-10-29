using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        protected string autor;
        protected TipoComic tipoComic;

        public Comic(string descripcion,int stock,double precio,string autor,TipoComic tipoComic) : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendFormat("Autor: {0}\n", this.autor);
            sb.AppendFormat("Tipo de comic: {0}\n", this.tipoComic);

            return sb.ToString();
        }

        public enum TipoComic{
            Occidental,
            Oriental
        }
    }
}
