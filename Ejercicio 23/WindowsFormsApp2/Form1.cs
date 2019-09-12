using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            this.txtCotizacionDolar.Enabled = !this.txtCotizacionDolar.Enabled;
            this.txtCotizacionEuro.Enabled = !this.txtCotizacionEuro.Enabled;
            this.txtCotizacionPeso.Enabled = !this.txtCotizacionPeso.Enabled;
            this.btnLockCotizacion.ImageIndex = this.btnLockCotizacion.ImageIndex == 1 ? 0 : 1;
            
        }

        private void txtCotizacionEuro_OnLeave(object sender, EventArgs e)
        {
            double aux;
            if(Double.TryParse(this.txtCotizacionEuro.Text, out aux))
            {
                Euro.SetCotizacion(aux);
            }
            else
            {
                this.txtCotizacionEuro.Focus();
            }

        }

        private void txtCotizacionDolar_OnLeave(object sender, EventArgs e)
        {
            double aux;
            if (Double.TryParse(this.txtCotizacionDolar.Text, out aux))
            {
                Dolar.SetCotizacion(aux);
            }
            else
            {
                this.txtCotizacionEuro.Focus();
            }
        }

        private void txtCotizacionPeso_OnLeave(object sender, EventArgs e)
        {
            double aux;
            if (Double.TryParse(this.txtCotizacionPeso.Text, out aux))
            {
                Pesos.SetCotizacion(aux);
            }
            else
            {
                this.txtCotizacionEuro.Focus();
            }
        }

        private void form1_OnLoad(object sender, EventArgs e)
        {
            this.txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            this.txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            this.txtCotizacionPeso.Text = Pesos.GetCotizacion().ToString();
        }

        private void btnConverEuro_OnClick(object sender, EventArgs e)
        {
            double aux;
            if(Double.TryParse(this.txtEuro.Text, out aux))
            {
                Euro eurs = new Euro(aux);
                Pesos pes = (Pesos)eurs;
                Dolar dolares = (Dolar)eurs;

                this.txtEuroAEuro.Text = eurs.GetCantidad().ToString();
                this.txtEuroADolar.Text = dolares.GetCantidad().ToString();
                this.txtEuroAPeso.Text = pes.GetCantidad().ToString();
            }
            else
            {
                this.txtEuro.Focus();
            }
        }

        private void btnConvertDolar_OnClick(object sender, EventArgs e)
        {
            double aux;
            if (Double.TryParse(this.txtEuro.Text, out aux))
            {
                Dolar dolares = new Dolar(aux);
                Pesos pes = (Pesos)dolares;
                Euro euros = (Euro)dolares;

                this.txtDolarAEuro.Text = euros.GetCantidad().ToString();
                this.txtDolarADolar.Text = dolares.GetCantidad().ToString();
                this.txtDolarAPeso.Text = pes.GetCantidad().ToString();
            }
            else
            {
                this.txtDolar.Focus();
            }
        }

        private void btnConvertPeso_OnClick(object sender, EventArgs e)
        {
            double aux;
            if (Double.TryParse(this.txtEuro.Text, out aux))
            {
                Pesos pes = new Pesos(aux);
                Dolar dolares = (Dolar)pes;
                Euro euros = (Euro)pes;

                this.txtPesoAEuro.Text = euros.GetCantidad().ToString();
                this.txtPesoADolar.Text = dolares.GetCantidad().ToString();
                this.txtPesoAPeso.Text = pes.GetCantidad().ToString();
            }
            else
            {
                this.txtPeso.Focus();
            }
        }
    }
}
