using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    class Comiqueria
    {
        protected List<Producto> productos;
        protected List<Venta> ventas;

        public Comiqueria()
        {
            this.productos = new List<Producto>;
            this.ventas = new List<Venta>;
        }


    }
}
