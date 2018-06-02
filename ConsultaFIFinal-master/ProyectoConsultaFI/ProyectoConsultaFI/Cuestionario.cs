using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProyectoConsultaFI
{
    public partial class Cuestionario : Form
    {

        //Se crea el cuestionario y se muestra la primer pregunta en pantalla.
        Form1 formPadre;
        public byte CerrarNoCerrar;
        public Cuestionario(Form1 formPadre)
        {
            this.formPadre = formPadre;
            MdiParent = formPadre;

            ConstruirCuestionario();

            PreguntasDelCuestionaro MostrarPregunta = (PreguntasDelCuestionaro)Preguntas[Numeros[NumeroPregunta]];

            InitializeComponent();

            TiempoCuestionario.Start();

            Minutos.Text = "19";
            //++NumeroPregunta
            lbPregunta.Text = (1).ToString() + "-. " + MostrarPregunta.Pregunta;
            radboA.Text = "A) " + MostrarPregunta.R1;
            radboB.Text = "B) " + MostrarPregunta.R2;
            radboC.Text = "C) " + MostrarPregunta.R3;

            GraficaPuntosCorrectos.Hide();
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (NumeroPregunta < 10)
            {
                PreguntasDelCuestionaro MostrarPregunta = (PreguntasDelCuestionaro)Preguntas[Numeros[NumeroPregunta]];
                //Aumenta el puntaje obtenido por el usuario.
                if (radboA.Checked)
                {
                    if (MostrarPregunta.R1 == MostrarPregunta.rCorrecta)
                    {
                        puntaje++;
                        incorrecta[NumeroPregunta] = 0;
                    }
                    else
                    {
                        incorrecta[NumeroPregunta] = MostrarPregunta.Tema;
                        FilaRIncorrectas.Enqueue(NumeroPregunta);
                    }
                }
                else if (radboB.Checked)
                {
                    if (MostrarPregunta.R2 == MostrarPregunta.rCorrecta)
                    {
                        puntaje++;
                        incorrecta[NumeroPregunta] = 0;
                    }
                    else
                    {
                        incorrecta[NumeroPregunta] = MostrarPregunta.Tema;
                        FilaRIncorrectas.Enqueue(NumeroPregunta);
                    }
                }
                else if (radboC.Checked)
                {
                    if (MostrarPregunta.R1 == MostrarPregunta.rCorrecta)
                    {
                        puntaje++;
                        incorrecta[NumeroPregunta] = 0;
                    }
                    else
                    {
                        incorrecta[NumeroPregunta] = MostrarPregunta.Tema;
                        FilaRIncorrectas.Enqueue(NumeroPregunta);
                    }
                }

                //Verifica que por lo menos un RadioButton está seleccionado para cambiar de pregunta.
                if (radboA.Checked || radboB.Checked || radboC.Checked)
                {
                    lbPregunta.Text = (++NumeroPregunta).ToString() + "-. " + MostrarPregunta.Pregunta;
                    radboA.Text = "A) " + MostrarPregunta.R1;
                    radboB.Text = "B) " + MostrarPregunta.R2;
                    radboC.Text = "C) " + MostrarPregunta.R3;
                    
                }
                else
                {
                    MessageBox.Show("No puedes pasar a la siguiente pregunta hasta que hayas seleccionado una opción.", "Respuesta no seleccionada");
                }

            }
            else
            {
                TiempoCuestionario.Stop();
                lbPregunta.Text = "Tuviste " + puntaje.ToString() + " respuestas correctas.";
                panelPreguntas.Hide();
                GraficaPuntosCorrectos.Show();
                int[] MisErrores = TemasIncorrectos(incorrecta);
                GraficaPuntosCorrectos.Titles.Add("Temas en que has tenido errores.");
                GraficaPuntosCorrectos.Series["Temas"].Points.AddXY("Tema 1", MisErrores[0]);
                GraficaPuntosCorrectos.Series["Temas"].Points.AddXY("Tema 2", MisErrores[1]);
                GraficaPuntosCorrectos.Series["Temas"].Points.AddXY("Tema 3", MisErrores[2]);
                GraficaPuntosCorrectos.Series["Temas"].Points.AddXY("Tema 4", MisErrores[3]);
            }
        }

        //Aquí se implementa la cuenta regresiva de 19 minutos y 60 segundos. 
        int SegundosRestantes = 60;
        int MinutosRestantes = 19;
        private void TiempoCuestionario_Tick(object sender, EventArgs e)
        {
            if (MinutosRestantes >= 0 )
            {
                if (SegundosRestantes >= 0)
                {
                    SegundosRestantes = SegundosRestantes - 1;
                    if (SegundosRestantes < 10)
                    {
                        Segundos.Text = "0" + SegundosRestantes.ToString();
                    }
                    else
                    {
                        Segundos.Text = SegundosRestantes.ToString();
                    }
                }
                else
                {
                    SegundosRestantes = 60;
                    MinutosRestantes = MinutosRestantes - 1;
                    if (MinutosRestantes < 10)
                    {
                        Minutos.Text = "0" + MinutosRestantes.ToString();
                    }
                    else
                    {
                        Minutos.Text = MinutosRestantes.ToString();
                    }
                }
            }
            else
            {
                TiempoCuestionario.Stop();
                MessageBox.Show("Se te ha acabado el tiempo.", "Tiempo"); 
                lbPregunta.Text = "Tuviste " + puntaje.ToString() + " respuestas correctas.";
                panelPreguntas.Hide();
                GraficaPuntosCorrectos.Show();
                int[] MisErrores = TemasIncorrectos(incorrecta);
                GraficaPuntosCorrectos.Titles.Add("Temas en que has tenido errores.");
                GraficaPuntosCorrectos.Series["Temas"].Points.AddXY("Tema 1", MisErrores[0]);
                GraficaPuntosCorrectos.Series["Temas"].Points.AddXY("Tema 2", MisErrores[1]);
                GraficaPuntosCorrectos.Series["Temas"].Points.AddXY("Tema 3", MisErrores[2]);
                GraficaPuntosCorrectos.Series["Temas"].Points.AddXY("Tema 4", MisErrores[3]);
            }
        }


        public int[] TemasIncorrectos(int[] TemasIncorrectos)
        {
            int tema1 = 0;
            int tema2 = 0;
            int tema3 = 0;
            int tema4 = 0;
            int[] Temas = new int[4];
            for (int i = 0; i < TemasIncorrectos.Length; i++)
            {
                if (TemasIncorrectos[i] == 1)
                {
                    tema1++;
                }
                else if (TemasIncorrectos[i] == 2)
                {
                    tema2++;
                }
                else if (TemasIncorrectos[i] == 3)
                {
                    tema3++;
                }
                else if (TemasIncorrectos[i] == 4)
                {
                    tema4++;
                }
            }

            Temas[0] = tema1; Temas[1] = tema2; Temas[2] = tema3; Temas[3] = tema4;
            return Temas; 
        }

      

        private void btnSalir_Click(object sender, EventArgs e)
        {
            SalirCuestionario Salir = new SalirCuestionario(this, formPadre);
            
            if (lbPregunta.Text.Contains("Tuviste"))
            {
                TiempoCuestionario.Stop();
                this.Close();
                formPadre.btnCuestionario.Enabled = true;
                formPadre.lbPrincipal.Text = "Consulta FI";
            }
            else
            {
                this.Enabled = false;
                TiempoCuestionario.Stop();
                Salir.Show();
            }


        }
    }
}
