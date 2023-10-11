using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoParcial_01pao.Formas
{
    public partial class FormaTalavera : Form
    {
        public FormaTalavera()
        {
            InitializeComponent();
        }

        private void FormaTalavera_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaHome home = new FormaHome();
            home.Show();
            Hide();
        }

        private void buttoncalsal_Click(object sender, EventArgs e)
        {
            try
            {
                float salario = float.Parse(textBox1sal.Text);
                float calculo = (float)Convert.ToDouble(0.25 * salario);
                float salario_new = calculo + salario;

                if (salario > 0)
                {
                    label2.Text = salario_new.ToString();
                }

                else
                    MessageBox.Show("Es negativo");
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingrese un valor válido");
            }

        }
    }
}
