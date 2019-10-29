using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase2
    {
        public void MetodoInstancia()
        {
            try
            {
                MiClase miClase = new MiClase(2);
            }
            catch(Exception e)
            {
                throw new MiExcepcion("mensaje2", e);
            }
        }
    }
}
