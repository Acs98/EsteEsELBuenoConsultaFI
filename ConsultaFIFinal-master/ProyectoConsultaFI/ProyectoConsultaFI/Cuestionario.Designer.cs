namespace ProyectoConsultaFI
{
    partial class Cuestionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lbPregunta = new System.Windows.Forms.Label();
            this.radboA = new System.Windows.Forms.RadioButton();
            this.radboC = new System.Windows.Forms.RadioButton();
            this.radboB = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.TiempoCuestionario = new System.Windows.Forms.Timer(this.components);
            this.Minutos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Segundos = new System.Windows.Forms.Label();
            this.GraficaPuntosCorrectos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelPreguntas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GraficaPuntosCorrectos)).BeginInit();
            this.panelPreguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPregunta
            // 
            this.lbPregunta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbPregunta.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPregunta.Location = new System.Drawing.Point(121, 21);
            this.lbPregunta.Name = "lbPregunta";
            this.lbPregunta.Size = new System.Drawing.Size(903, 44);
            this.lbPregunta.TabIndex = 0;
            this.lbPregunta.Text = "Pregunta";
            this.lbPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radboA
            // 
            this.radboA.AutoSize = true;
            this.radboA.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radboA.Location = new System.Drawing.Point(68, 74);
            this.radboA.Name = "radboA";
            this.radboA.Size = new System.Drawing.Size(45, 22);
            this.radboA.TabIndex = 1;
            this.radboA.TabStop = true;
            this.radboA.Text = "a) ";
            this.radboA.UseVisualStyleBackColor = true;
            // 
            // radboC
            // 
            this.radboC.AutoSize = true;
            this.radboC.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radboC.Location = new System.Drawing.Point(831, 74);
            this.radboC.Name = "radboC";
            this.radboC.Size = new System.Drawing.Size(40, 22);
            this.radboC.TabIndex = 1;
            this.radboC.TabStop = true;
            this.radboC.Text = "c)";
            this.radboC.UseVisualStyleBackColor = true;
            // 
            // radboB
            // 
            this.radboB.AutoSize = true;
            this.radboB.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radboB.Location = new System.Drawing.Point(469, 74);
            this.radboB.Name = "radboB";
            this.radboB.Size = new System.Drawing.Size(41, 22);
            this.radboB.TabIndex = 1;
            this.radboB.TabStop = true;
            this.radboB.Text = "b)";
            this.radboB.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Location = new System.Drawing.Point(501, 150);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(124, 23);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente Pregunta";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // TiempoCuestionario
            // 
            this.TiempoCuestionario.Interval = 50;
            this.TiempoCuestionario.Tick += new System.EventHandler(this.TiempoCuestionario_Tick);
            // 
            // Minutos
            // 
            this.Minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minutos.Location = new System.Drawing.Point(1045, 15);
            this.Minutos.Name = "Minutos";
            this.Minutos.Size = new System.Drawing.Size(30, 23);
            this.Minutos.TabIndex = 4;
            this.Minutos.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1069, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // Segundos
            // 
            this.Segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Segundos.Location = new System.Drawing.Point(1081, 15);
            this.Segundos.Name = "Segundos";
            this.Segundos.Size = new System.Drawing.Size(32, 24);
            this.Segundos.TabIndex = 5;
            this.Segundos.Text = "--";
            // 
            // GraficaPuntosCorrectos
            // 
            chartArea2.Name = "ChartArea1";
            this.GraficaPuntosCorrectos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GraficaPuntosCorrectos.Legends.Add(legend2);
            this.GraficaPuntosCorrectos.Location = new System.Drawing.Point(72, 106);
            this.GraficaPuntosCorrectos.Name = "GraficaPuntosCorrectos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Temas";
            this.GraficaPuntosCorrectos.Series.Add(series2);
            this.GraficaPuntosCorrectos.Size = new System.Drawing.Size(466, 367);
            this.GraficaPuntosCorrectos.TabIndex = 6;
            this.GraficaPuntosCorrectos.Text = "chart1";
            title2.Name = "Temas.";
            this.GraficaPuntosCorrectos.Titles.Add(title2);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(990, 413);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(88, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelPreguntas
            // 
            this.panelPreguntas.Controls.Add(this.panel2);
            this.panelPreguntas.Controls.Add(this.radboB);
            this.panelPreguntas.Controls.Add(this.radboC);
            this.panelPreguntas.Controls.Add(this.btnSiguiente);
            this.panelPreguntas.Controls.Add(this.Segundos);
            this.panelPreguntas.Controls.Add(this.radboA);
            this.panelPreguntas.Controls.Add(this.label3);
            this.panelPreguntas.Controls.Add(this.Minutos);
            this.panelPreguntas.Location = new System.Drawing.Point(3, 82);
            this.panelPreguntas.Name = "panelPreguntas";
            this.panelPreguntas.Size = new System.Drawing.Size(1139, 201);
            this.panelPreguntas.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Location = new System.Drawing.Point(498, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 23);
            this.panel2.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Location = new System.Drawing.Point(987, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 22);
            this.panel1.TabIndex = 9;
            // 
            // Cuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1142, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPreguntas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lbPregunta);
            this.Controls.Add(this.GraficaPuntosCorrectos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuestionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuestionario";
            ((System.ComponentModel.ISupportInitialize)(this.GraficaPuntosCorrectos)).EndInit();
            this.panelPreguntas.ResumeLayout(false);
            this.panelPreguntas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPregunta;
        private System.Windows.Forms.RadioButton radboA;
        private System.Windows.Forms.RadioButton radboC;
        private System.Windows.Forms.RadioButton radboB;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label Minutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Segundos;
        private System.Windows.Forms.DataVisualization.Charting.Chart GraficaPuntosCorrectos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelPreguntas;
        public System.Windows.Forms.Timer TiempoCuestionario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}