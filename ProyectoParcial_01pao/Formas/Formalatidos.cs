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
    public partial class Formalatidos : Form
    {
        public Formalatidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaHome home = new FormaHome();
            home.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double edad = double.Parse(textBoxedad.Text);

                //if (double.TryParse(textBoxedad.Text, out double edad))
                {
                    double TMC = 220 - edad;

                    if (edad > 0)
                        labellatidos.Text = ($"{TMC}");

                    else
                        MessageBox.Show("Es negativo");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Error de datos");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Formalatidos_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
