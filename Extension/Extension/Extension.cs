using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    public static class Extension
    {
        public static int ContarPalabras(this string instancia)
        {
            string[] palabras = instancia.Split(' ');
            return palabras.Count();
        }
    }
}
