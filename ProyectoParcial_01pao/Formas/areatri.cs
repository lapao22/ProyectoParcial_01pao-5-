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
    public partial class areatri : Form
    {
        public areatri()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaHome home = new FormaHome();
            home.Show();
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void botonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float baseT = float.Parse(textoBase.Text);
                float altura = float.Parse(textoAltura.Text);

                if
                    (baseT > 0 && baseT > 0)
                    MessageBox.Show("Area Triangulo   " + (baseT * altura / 2));

                else
                    MessageBox.Show("Es negativo");
            }
            catch
            {
                MessageBox.Show("Ingresar un valor válido");
            }
        }

        private void areatri_Load(object sender, EventArgs e)
        {

        }
    }
}
