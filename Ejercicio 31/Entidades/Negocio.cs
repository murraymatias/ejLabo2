using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue clientes;
        private string nombre;

        private Negocio()
        {
            clientes = new Queue();
        }
        public Cliente Cliente
        {

        }

    }
}
