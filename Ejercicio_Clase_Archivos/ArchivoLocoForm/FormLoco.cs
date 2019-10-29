using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Entities;

namespace ArchivoLocoForm
{
    public partial class FormLoco : Form
    {
        private const string EXTENSION_VALIDA = ".txt";

        public FormLoco()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Archivador.SaveTxt(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),false,"outputText",richTextBoxTexto.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void buttonLeer_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;

                if (Path.GetExtension(fileName) == EXTENSION_VALIDA)
                {
                    try
                    {
                        richTextBoxTexto.Text = Archivador.LoadText(fileName);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid file extension.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}
