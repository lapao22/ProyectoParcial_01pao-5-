using System;
using System.Windows.Forms;

namespace ProyectoParcial_01pao.Formas
{
    public partial class FormaVideo : Form
    {
        public FormaVideo()
        {
            InitializeComponent();
        }

        private void FormaVideo_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @" C:\Users\ramir\Downloads\Mon.mp4";
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
