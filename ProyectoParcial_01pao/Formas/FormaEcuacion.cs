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
    public partial class FormaEcuacion : Form
    {
        public FormaEcuacion()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            FormaHome home = new FormaHome();
            home.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double cuadratica = double.Parse(texta.Text);
                double valorA = double.Parse(texta.Text);
                double valorB = double.Parse(textb.Text);
                double valorC = double.Parse(textc.Text);

                if (cuadratica > 0 && valorA > 0 && valorB > 0 && valorC > 0)
                {
                    double xuno = (-valorB + Math.Sqrt(cuadratica)) / (2 * valorA);
                    double xdos = (-valorB - Math.Sqrt(cuadratica)) / (2 * valorA);

                    labelx1.Text = xuno.ToString();
                    labelx2.Text = xdos.ToString();

                }
                else
                    MessageBox.Show("Es negativo");
            }
            catch
            {
                MessageBox.Show("Ingresa un valor válido");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           


        }
    }
}
