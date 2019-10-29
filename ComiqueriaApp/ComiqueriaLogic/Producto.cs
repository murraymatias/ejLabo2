using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        protected Guid codigo;
        protected string descripcion;
        protected double precio;
        protected int stock;

        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public double Precio
        {
            get { return this.precio; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { if (value >= 0){ this.stock = value; }}
        }

        public static explicit operator Guid(Producto p)
        {
            return p.codigo;
        }

        protected Producto(string descripcion, int stock, double precio)
        {
            this.codigo = new Guid();
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Descipcion: {0}\n", this.descripcion);
            sb.AppendFormat("Codigo: {0}\n", this.codigo);
            sb.AppendFormat("Precio: ${0}\n", this.precio);
            sb.AppendFormat("Stock: {0}\n", this.stock);

            return this.ToString();
        }
    }
}
