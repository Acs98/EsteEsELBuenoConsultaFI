using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoConsultaFI
{
    public partial class AgregarDocumento : Form
    {
       
        Form1 formPadre;
        public AgregarDocumento(Form1 formPadre)
        {
            this.formPadre = formPadre;
            InitializeComponent();
        }

        private void AgregarDocumento_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.consultaFI.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            formPadre.lbPrincipal.Text = "Consulta FI";
        }

        private void lklbTema1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormHijo(new AgregandoNota(lklbTema1.Text));
        }

        private void lklbTema2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormHijo(new AgregandoNota(lklbTema2.Text));
        }

        private void lklbTema3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormHijo(new AgregandoNota(lklbTema3.Text));
        }

        private void lklbTema4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirFormHijo(new AgregandoNota(lklbTema4.Text));
        }




        private void AbrirFormHijo(object formhijo)
        {
            if (formPadre.miPanelContenedor.Controls.Count > 0)
            {
                formPadre.miPanelContenedor.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            formPadre.miPanelContenedor.Controls.Add(fh);
            formPadre.miPanelContenedor.Tag = fh;
            fh.Show();
        }

    }
}
