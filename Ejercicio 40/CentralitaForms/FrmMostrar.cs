using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace CentralitaForms
{
    public partial class FrmMostrar : Form
    {
        Centralita centralita;
        public FrmMostrar(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            rtxtResultado.Text = centralita.ToString();
        }
    }
}
