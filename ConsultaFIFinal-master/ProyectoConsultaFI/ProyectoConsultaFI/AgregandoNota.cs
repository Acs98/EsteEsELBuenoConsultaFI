using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProyectoConsultaFI
{
    public partial class AgregandoNota : Form
    {
        FileStream fs;
        StreamWriter sw;
        StreamReader sr;
        public string Nombre;
        public string contenido;

        public AgregandoNota(string TemaActual)
        {
           
            InitializeComponent();
            lbNota.Text = TemaActual;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          
        }



        int nota = 1;
        private void btnGuardarComo_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Documento de Texto|*.txt";
            saveFile.Title = "Guardar Nota";
            saveFile.FileName = "Nota " + nota.ToString();
            nota++;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(saveFile.FileName, FileMode.Append, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    foreach (var line in richtbNotas.Lines)
                    {
                        sw.WriteLine(line);
                    }
                }
                catch (IOException error)
                {
                    MessageBox.Show("Error " + error.Message);
                }
                finally
                {
                    sw.Close();
                    fs.Close();
                }
            }

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Documento de Texto|*.txt";
            openFile.Title = "Abrir Nota";
            

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fs = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    richtbNotas.Text = sr.ReadToEnd();
                }
                catch (IOException error)
                {
                    MessageBox.Show("Error " + error.Message);
                }
                finally
                {
                    sr.Close();
                    fs.Close();
                }
            }

            
        }



       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (richtbNotas.Text != null)
            {
                richtbNotas.Clear();
                richtbNotas.Focus();
            }


        }
    }
    
}
