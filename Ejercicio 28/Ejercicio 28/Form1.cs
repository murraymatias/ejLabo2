using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_OnClick(object sender, EventArgs e)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string[] words = rtxtUser.Text.Split(' ');
            
            foreach(string word in words)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }
           
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<string,int> word in dict.OrderByDescending(key => key.Value))
            {
                sb.AppendFormat("Palabra: {0} Apariciones: {1}\n", word.Key, word.Value);                
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
