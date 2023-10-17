using System;
using System.Windows.Forms;
using ProyectoParcial_01pao.Formas;

namespace ProyectoParcial_01pao.Formas
{
    public partial class FormaHome : Form
    {
        public FormaHome()
        {
            InitializeComponent();
        }

        private void menuRegistro_Click(object sender, EventArgs e)
        {
            menuRegistrodeUsuarios forma = new menuRegistrodeUsuarios ();
            forma.Show();
        }

        private void FormaHome_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuVideo01_Click(object sender, EventArgs e)
        {
            FormaVideo video = new FormaVideo();
            video.Show();

        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuCalculadora_Click(object sender, EventArgs e)
        {
            areatri forma = new areatri();
            forma.Show();
        }

        private void cambioDePesosADólaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaPesosDolares forma = new FormaPesosDolares();
            forma.Show();

        }

        private void latidosPorMinutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formalatidos forma = new Formalatidos();
            forma.Show();
                
        }

        private void fábricaDeTalaveraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaTalavera forma = new FormaTalavera();
            forma.Show();
               

        }

        private void ecuaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaEcuacion forma = new FormaEcuacion();
            forma.Show();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormaDudas forma = new FormaDudas();
            forma.Show();


        }

        private void visorDeImágenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaVisor forma = new FormaVisor();
            forma.Show();
        }

        private void matemáticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaMate forma = new FormaMate();
            forma.Show();
        }


        private void juegoDeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormaJuego forma = new FormaJuego();
            forma.Show();
        }
    }
}
