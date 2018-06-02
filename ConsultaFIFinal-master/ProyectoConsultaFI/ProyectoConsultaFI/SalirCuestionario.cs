using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoConsultaFI
{
    public partial class SalirCuestionario : Form
    {
        
        Cuestionario formPadre;
        Form1 SuperPadre;
        public SalirCuestionario(Cuestionario formPadre, Form1 SuperPadre)
        {
            this.formPadre = formPadre;
            this.SuperPadre = SuperPadre;
            InitializeComponent();
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            formPadre.TiempoCuestionario.Stop();
            formPadre.Close();
            SuperPadre.btnCuestionario.Enabled = true; 
            this.Close();
            SuperPadre.lbPrincipal.Text = "Consulta FI";
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            formPadre.Enabled = true;
            formPadre.TiempoCuestionario.Start();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            formPadre.Enabled = true;
            formPadre.TiempoCuestionario.Start();
            this.Close();
        }
    }
}
