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
    public partial class FormaVisor : Form
    {
        public FormaVisor()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            FormaHome home = new FormaHome();
            home.Show();
            Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //JPEG Files(*.jpg)| *.jpg | PNG Files(*.png) | *.png | BMP Files(*.bmp) | *.bmp | All files(*.*) | *.*
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxpaisaje.Load(openFileDialog1.FileName);
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBoxpaisaje.BackColor = colorDialog1.Color;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            pictureBoxpaisaje.Image = null;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxajustar.Checked)
                pictureBoxpaisaje.SizeMode = PictureBoxSizeMode.StretchImage;

            else
                pictureBoxpaisaje.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void pictureBoxpaisaje_Click(object sender, EventArgs e)
        {

        }
    }
}
