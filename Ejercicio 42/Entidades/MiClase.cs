using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MiClase
    {
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException("divide by zero");
        }
        public MiClase()
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public MiClase(int n)
        {
            try
            {
                MiClase miClase = new MiClase();
            }
            catch(Exception e)
            {
                throw new UnaExcepcion("mensaje", e);
            }
        }

    }
}
