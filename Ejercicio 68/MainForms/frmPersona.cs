using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForms
{
    public partial class frmPersona : Form
    {
        private Persona persona;
        public frmPersona()
        {
            InitializeComponent();
        }

        public void NotificarCambio(string msg)
        {
            MessageBox.Show(msg+"\n"+persona.Mostrar());
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(this.persona == null)
            {
                this.persona = new Persona();
                this.persona.Apellido = this.txtApellido.Text;
                this.persona.Nombre = this.txtNombre.Text;
                this.persona.EventoString += NotificarCambio;
                this.btnCrear.Text = "Actualizar";
            }
            else
            {
                this.persona.Apellido = this.txtApellido.Text;
                this.persona.Nombre = this.txtNombre.Text;
            }
        }
    }
}
