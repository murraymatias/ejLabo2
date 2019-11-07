using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Mascota
    {
        private string nombre;
        private int idHumano;

        public Mascota(string nombre,int idHumano)
        {
            this.nombre = nombre;
            this.idHumano = idHumano;
        }
    }

}
