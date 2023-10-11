using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoParcial_01pao.Formas;

namespace ProyectoParcial_01pao
{
    public partial class FormaLoing : Form
    {
        public FormaLoing()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = textoUsuario.Text;
                string contraseña = textoClave.Text;
                if (usuario.Equals("pao") && contraseña.Equals("22"))

                {
                    FormaHome formaHome = new FormaHome();
                    formaHome.Show();
                }

                else if (string.IsNullOrEmpty(textoUsuario.Text) || string.IsNullOrEmpty(textoClave.Text))
                {
                    MessageBox.Show("ERROR : INGRESE DATOS DE USUARIO Y CONTRASEÑA");
                }

                else
                {
                    MessageBox.Show("Error : Usuario y contraseña incorrectos");
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Error, ingrese datos válidos");
            }
          
        }  
    }
}
