using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entities
{
    public class Temporizador
    {
        private Thread hilo;
        private int intervalo;

        public bool Activo
        {
            get
            {
                if(this.hilo != null)
                {
                    return this.hilo.IsAlive;
                }
                return false;
            }
            set
            {
                if (value)
                {
                    if(this.hilo == null || !this.hilo.IsAlive)
                    {
                        this.hilo = new Thread(Corriendo);
                        this.hilo.Start();
                    }
                }
                else
                {
                    if(this.hilo != null && this.hilo.IsAlive)
                    {
                        this.hilo.Abort();
                    }
                }
            }
        }        

        public int Intervalo
        {
            get { return this.intervalo; }
            set { this.intervalo = value; }
        }

        private void Corriendo()
        {
            while (true)
            {
                if(EventoTiempo != null)
                {
                    EventoTiempo.Invoke();
                }
                Thread.Sleep(intervalo);
            }
        }

        public delegate void encargadoTiempo();

        public event encargadoTiempo EventoTiempo;
    }
}
