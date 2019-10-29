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
    public partial class frmMenu : Form
    {
        private Centralita c;
        public frmMenu()
        {
            InitializeComponent();
            c = new Centralita("Lorem Ipsum");
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
        }

        private void BtnGenerarLlamada_Click(object sender, EventArgs e)
        {
            frmLlamador llamador = new frmLlamador(c);
            llamador.ShowDialog();
        }

        private void BtnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(c);
            frmMostrar.ShowDialog();
        }
    }
}
