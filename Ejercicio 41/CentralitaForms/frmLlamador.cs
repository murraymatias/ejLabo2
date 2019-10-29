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
    public partial class frmLlamador : Form
    {
        private Centralita centralita;

        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }

        public frmLlamador(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            txtNroDestino.Text = "Nro Destino";
            txtNroOrigen.Text = "Nro Origen";
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if(aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "1";
            txtNroDestino.Text = aux;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if (aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "2";
            txtNroDestino.Text = aux;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if (aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "3";
            txtNroDestino.Text = aux;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if (aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "4";
            txtNroDestino.Text = aux;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if (aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "5";
            txtNroDestino.Text = aux;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if (aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "6";
            txtNroDestino.Text = aux;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if (aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "7";
            txtNroDestino.Text = aux;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if (aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "8";
            txtNroDestino.Text = aux;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if (aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "9";
            txtNroDestino.Text = aux;
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if (aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "0";
            txtNroDestino.Text = aux;
        }

        private void BtnAsterisco_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if (aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "*";
            txtNroDestino.Text = aux;
        }

        private void BtnNumeral_Click(object sender, EventArgs e)
        {
            string aux = txtNroDestino.Text;
            if (aux == "Nro Destino")
            {
                aux = String.Empty;
            }
            aux += "#";
            txtNroDestino.Text = aux;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = "Nro Destino";
            txtNroOrigen.Text = "Nro Origen";
        }

        private void TxtNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (txtNroDestino.Text[0] == '#')
            {
                cmbFranja.Enabled = true;
            }
            else
            {
                cmbFranja.Enabled = false;
            }
        }

        private void BtnLlamar_Click(object sender, EventArgs e)
        {
            if (txtNroDestino.Text != "Nro Destino")
            {
                Random duracion = new Random();
                if (txtNroDestino.Text[0] == '#')
                {
                    try
                    {
                        Provincial.Franja franjas;
                        Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);
                        Provincial llamada = new Provincial(txtNroDestino.Text, franjas, duracion.Next(1, 50), txtNroDestino.Text);
                        centralita += llamada;
                        txtNroDestino.Text = "Nro Destino";
                        txtNroOrigen.Text = "Nro Origen";
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else
                {
                    try
                    {
                        Local llamada = new Local(txtNroOrigen.Text, (duracion.Next(5, 56)) / 10, txtNroDestino.Text, duracion.Next(1, 50));
                        centralita += llamada;
                        txtNroDestino.Text = "Nro Destino";
                        txtNroOrigen.Text = "Nro Origen";
                    }
                    catch(Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
