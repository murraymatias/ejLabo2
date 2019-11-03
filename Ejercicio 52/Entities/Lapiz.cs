using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get => ConsoleColor.Gray;
            set => throw  new NotImplementedException();
        }

        float IAcciones.UnidadesDeEscritura
        {
            get => this.tamanioMina;
            set => this.tamanioMina = value;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            string writhedText = null;

            foreach (char c in texto)
            {
                if (this.tamanioMina <= 0) break;

                writhedText += c;

                if (c == ' ') continue;

                this.tamanioMina -= (float)0.1;
            }

            return new EscrituraWrapper(writhedText, ConsoleColor.Gray);
        }

        bool IAcciones.Recargar(int unidades) { throw  new NotImplementedException();}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Lapiz");
            sb.AppendFormat("Color: {0}", ((IAcciones)this).Color.ToString());

            return sb.ToString();
        }
    }
}
