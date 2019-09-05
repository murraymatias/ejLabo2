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
            foreach (Producto p1 in e.GetProductos())
            {
                if (p1 == p)
                {
                    
                    return false;
                }
            }
            return true;
        }

        public static bool operator +(Estante e, Producto p)
        {
            Producto[] aux = e.GetProductos();
            if(e!=p)
            {
                for(int i=0;i>aux.Length;i++)
                {
                    if(aux[i] is null)
                    {
                        aux[i] = p;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
