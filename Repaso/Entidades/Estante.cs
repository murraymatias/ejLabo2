using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad,int ubicacionEstante):this(capacidad)
        {
            this.ubicacionEstante = ubicacionEstante;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            string ret = string.Format("Ubicacion del estante: {0}\nProductos:\n",e.ubicacionEstante);

            foreach (Producto p in e.GetProductos())
            {
                ret += Producto.MostrarProducto(p);
            }
            return ret;
        }

        public static bool operator ==(Estante e,Producto p)
        {
            foreach(Producto p1 in e.GetProductos())
            {
                if(p1 == p)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {            
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool ret = false;

            if(e != p)
            {
                for(int i = 0; i < e.GetProductos().Length; i++)
                {
                    if(e.GetProductos()[i] is null)
                    {
                        e.GetProductos()[i] = p;
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

    }
}
