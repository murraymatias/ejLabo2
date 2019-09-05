using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        private string marca;
        private string codigoDeBarras;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarras = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            string ret = "";

            if (!(p is null))
            {
                ret += string.Format(
                   "Marca: {0}\n" +
                   "Precio: {1}\n" +
                   "Codigo de barras: {2}\n\n", p.marca, p.precio, p.codigoDeBarras);
            }
            return ret;
        }

        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarras;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool ret = false;

            if (!(p1 is null || p2 is null))
            {
                if (p1.codigoDeBarras == p2.codigoDeBarras && p1.marca == p2.marca)
                {
                    return true;
                }
            }
            return ret;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return (!(p1 == p2));
        }

        public static bool operator ==(Producto p, string marca)
        {
            if(p.marca == marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Producto p, string marca)
        {
            if(p.marca != marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
