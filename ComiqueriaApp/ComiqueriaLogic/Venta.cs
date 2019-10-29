using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    sealed class Venta
    {
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;

        static Venta()
        {
            porcentajeIva = 21;
        }

        internal DateTime Fecha
        {
            get { return this.fecha; }
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            this.Vender(cantidad);
        }

        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad,int cantidad)
        {
            return precioUnidad * cantidad * Venta.porcentajeIva / 100;
        }

        public string ObtenerDescripcionBreve()
        {
            return string.Format("{0}-{1}-{2}", this.fecha, this.producto.Descripcion, this.precioFinal);
        }
    }
}
