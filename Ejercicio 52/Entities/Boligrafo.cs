using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Boligrafo : IAcciones
    {
        private ConsoleColor _colorTinta;
        private float _tinta;

        public ConsoleColor Color
        {
            get => this._colorTinta;
            set => this._colorTinta = value;
        }

        public float UnidadesDeEscritura
        {
            get => this._tinta;
            set => this._tinta = value;
        }

        public Boligrafo(int unidades, ConsoleColor color)
        {
            this._colorTinta = color;
            this._tinta = unidades;
        }

        public EscrituraWrapper Escribir(string texto)
        {
            string writhedText = null;

            foreach (char c in texto)
            {
                if (_tinta <= 0) break;

                writhedText += c;

                if(c == ' ') continue;

                this._tinta -= (float)0.3;
            }

            return  new EscrituraWrapper(writhedText,this.Color);
        }

        public bool Recargar(int unidades)
        {
            this._tinta += unidades;

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Boligrafo");
            sb.AppendFormat("Color: {0}", this.Color.ToString());

            return sb.ToString();
        }
    }
}
