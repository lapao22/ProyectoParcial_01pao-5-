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
    public partial class FormaPesosDolares : Form
    {
        public FormaPesosDolares()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormaHome home = new FormaHome();
            home.Show();
            Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double pesos = double.Parse(Boxpesos.Text);
                if(pesos <=0)
                {
                    MessageBox.Show("Es negativo");
                }
                //if (double.TryParse(Boxpesos.Text, out double pesos))
                else
                {
                    double dolar = (pesos / 2) / 17.40;
                    double euros = (pesos / 2) / 18.42;

                    labeldolar.Text = dolar.ToString();
                    labeleuro.Text = euros.ToString();

                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Ingresa un dato válido");
            }
            
        }

        private void FormaPesosDolares_Load(object sender, EventArgs e)
        {

        }
    }
}
