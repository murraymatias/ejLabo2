using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patentes;
using VistaPatentes;
using Entidades;
using Archivos;
using System.Threading;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        Queue<Patente> cola;
        List<Thread> threads;

        public FrmPpal()
        {
            InitializeComponent();

            this.cola = new Queue<Patente>();
            this.threads = new List<Thread>();
        }

        private void IniciarSimulacion()
        {
            this.FinalizarSimulacion();
            this.ProximaPatente(vistaPatente1);
            this.ProximaPatente(vistaPatente2);
        }

        private void ProximaPatente(VistaPatente vp)
        {
            if (this.cola.Count > 0)
            {
                Thread thread = new Thread(vp.MostrarPatente);
                thread.Start(cola.Dequeue());
                this.threads.Add(thread);
            }
        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {
            vistaPatente1.finExposicion += ProximaPatente;
            vistaPatente2.finExposicion += ProximaPatente;
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            Xml<Queue<Patente>> patente = new Xml<Queue<Patente>>();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            patente.Leer(openFileDialog.FileName,out this.cola);
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            Texto patente = new Texto();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            patente.Leer(openFileDialog.FileName, out this.cola);
            StringBuilder sb = new StringBuilder();

            foreach (Patente p in this.cola)
            {
                sb.AppendLine(p.ToString());
            }
            MessageBox.Show(sb.ToString());

            this.IniciarSimulacion();
        }
        private void btnSql_Click(object sender, EventArgs e)
        {

        }

        private void FinalizarSimulacion()
        {
            foreach(Thread thread in this.threads)
            {
                if (thread.IsAlive)
                {
                    thread.Abort();
                }
            }
        }
    }
}
