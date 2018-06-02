using System;
using System.Collections.Generic;

namespace ProyectoConsultaFI
{
    class PreguntasDelCuestionaro
    {
        private string pregunta;
        private string r1;
        private string r2;
        private string r3;
        private string rcorrecta;
        private int tema;
        
        public string Pregunta
        {
            get
            {
                return pregunta;
            }
            set
            {
                if (value == "")
                {
                    value = "Error. Reinicie el Programa.";
                }
                else
                {
                    pregunta = value;
                }

            }
        }

        public string R1
        {
            get
            {
                return r1;
            }
            set
            {
                if (value == "")
                {
                    value = "Error. Reinicie el Programa.";
                }
                else
                {
                    r1 = value;
                }

            }
        }

        public string R2
        {
            get
            {
                return r2;
            }
            set
            {
                if (value == "")
                {
                    value = "Error. Reinicie el Programa.";
                }
                else
                {
                    r2 = value;
                }

            }
        }

        public string R3
        {
            get
            {
                return r3;
            }
            set
            {
                if (value == "")
                {
                    value = "Error. Reinicie el Programa.";
                }
                else
                {
                    r3 = value;
                }

            }
        }

        public string rCorrecta
        {
            get
            {
                return rcorrecta;
            }
            set
            {
                if (value == "")
                {
                    value = "Error. Reinicie el Programa.";
                }
                else
                {
                    rcorrecta = value;
                }

            }
        }

        public int Tema
        {
            get
            {
                return tema;
            }
            set
            {
                if (value == 0)
                {
                    value = -1;
                }
                else
                {
                    tema = value;
                }

            }
        }

        public PreguntasDelCuestionaro(string Pregunta, string R1, string R2, string R3, string rCorrecta, int Tema)
        {
            this.Pregunta = Pregunta;
            this.R1 = R1;
            this.R2 = R2;
            this.R3 = R3;
            this.rCorrecta = rCorrecta;
            this.Tema = Tema;
        }




    }
}
