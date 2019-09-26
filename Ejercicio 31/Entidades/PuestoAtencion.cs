using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual
        {
            set
            {
                numeroActual++;
            }
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cli)
        {
            System.Threading.Thread.Sleep(3000);
            return true;
        }

        public enum Puesto
        {
            Caja1,
            Caja2
        }
    }
}
