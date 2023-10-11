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
    public partial class menuRegistrodeUsuarios : Form
    {
        public menuRegistrodeUsuarios()
        {
            InitializeComponent();
        }

        private void menuRegistrodeUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registrar_Click(object sender, EventArgs e)
        {
           
            FormaHome home = new FormaHome();
            home.Show();
            Hide();

        }
    }
}
