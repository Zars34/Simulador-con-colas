namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cant_autos1 = new NumericUpDown();
            cant_minutos1 = new NumericUpDown();
            cant_minutos2 = new NumericUpDown();
            cant_autos2 = new NumericUpDown();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label7 = new Label();
            label8 = new Label();
            espera_auto = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            precio_vagon = new NumericUpDown();
            precio_auto = new NumericUpDown();
            label12 = new Label();
            costo_auto = new NumericUpDown();
            label13 = new Label();
            label14 = new Label();
            cant_minutos_viaje = new NumericUpDown();
            label15 = new Label();
            label16 = new Label();
            cant_minutos_simulacion = new NumericUpDown();
            button2 = new Button();
            label17 = new Label();
            label18 = new Label();
            cant_minutos_viaje_vacio = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)cant_autos1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cant_minutos1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cant_minutos2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cant_autos2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)espera_auto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)precio_vagon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)precio_auto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)costo_auto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cant_minutos_viaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cant_minutos_simulacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cant_minutos_viaje_vacio).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 409);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 0;
            button1.Text = "Primera Simulacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(78, 24);
            label2.TabIndex = 2;
            label2.Text = "Parada 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 36);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "Autos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 36);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 4;
            label4.Text = "Minutos:";
            // 
            // cant_autos1
            // 
            cant_autos1.Location = new Point(94, 36);
            cant_autos1.Name = "cant_autos1";
            cant_autos1.Size = new Size(47, 27);
            cant_autos1.TabIndex = 5;
            cant_autos1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cant_minutos1
            // 
            cant_minutos1.Location = new Point(230, 36);
            cant_minutos1.Name = "cant_minutos1";
            cant_minutos1.Size = new Size(47, 27);
            cant_minutos1.TabIndex = 6;
            cant_minutos1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cant_minutos2
            // 
            cant_minutos2.Location = new Point(230, 104);
            cant_minutos2.Name = "cant_minutos2";
            cant_minutos2.Size = new Size(47, 27);
            cant_minutos2.TabIndex = 10;
            cant_minutos2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // cant_autos2
            // 
            cant_autos2.Location = new Point(94, 106);
            cant_autos2.Name = "cant_autos2";
            cant_autos2.Size = new Size(47, 27);
            cant_autos2.TabIndex = 9;
            cant_autos2.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 106);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 8;
            label5.Text = "Minutos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(23, 106);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 7;
            label6.Text = "Autos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(78, 24);
            label1.TabIndex = 11;
            label1.Text = "Parada 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 151);
            label7.Name = "label7";
            label7.Size = new Size(252, 24);
            label7.TabIndex = 12;
            label7.Text = "Tiempo de espera antes de irse";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 186);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 13;
            label8.Text = "Minutos:";
            // 
            // espera_auto
            // 
            espera_auto.Location = new Point(94, 186);
            espera_auto.Name = "espera_auto";
            espera_auto.Size = new Size(47, 27);
            espera_auto.TabIndex = 14;
            espera_auto.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 225);
            label9.Name = "label9";
            label9.Size = new Size(68, 24);
            label9.TabIndex = 15;
            label9.Text = "Precios";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(23, 258);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 16;
            label10.Text = "Vagon:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(164, 258);
            label11.Name = "label11";
            label11.Size = new Size(50, 20);
            label11.TabIndex = 17;
            label11.Text = "Autos:";
            // 
            // precio_vagon
            // 
            precio_vagon.Location = new Point(94, 258);
            precio_vagon.Name = "precio_vagon";
            precio_vagon.Size = new Size(47, 27);
            precio_vagon.TabIndex = 18;
            precio_vagon.Value = new decimal(new int[] { 6, 0, 0, 0 });
            // 
            // precio_auto
            // 
            precio_auto.Location = new Point(230, 256);
            precio_auto.Name = "precio_auto";
            precio_auto.Size = new Size(47, 27);
            precio_auto.TabIndex = 19;
            precio_auto.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(164, 186);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 20;
            label12.Text = "Costo:";
            // 
            // costo_auto
            // 
            costo_auto.Location = new Point(230, 184);
            costo_auto.Name = "costo_auto";
            costo_auto.Size = new Size(47, 27);
            costo_auto.TabIndex = 21;
            costo_auto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(12, 299);
            label13.Name = "label13";
            label13.Size = new Size(131, 24);
            label13.TabIndex = 22;
            label13.Text = "Tiempo de viaje";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(23, 335);
            label14.Name = "label14";
            label14.Size = new Size(65, 20);
            label14.TabIndex = 23;
            label14.Text = "Minutos:";
            // 
            // cant_minutos_viaje
            // 
            cant_minutos_viaje.Location = new Point(94, 333);
            cant_minutos_viaje.Name = "cant_minutos_viaje";
            cant_minutos_viaje.Size = new Size(47, 27);
            cant_minutos_viaje.TabIndex = 24;
            cant_minutos_viaje.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(343, 9);
            label15.Name = "label15";
            label15.Size = new Size(179, 24);
            label15.TabIndex = 25;
            label15.Text = "Tiempo de simulacion";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(360, 38);
            label16.Name = "label16";
            label16.Size = new Size(65, 20);
            label16.TabIndex = 26;
            label16.Text = "Minutos:";
            // 
            // cant_minutos_simulacion
            // 
            cant_minutos_simulacion.Location = new Point(431, 34);
            cant_minutos_simulacion.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            cant_minutos_simulacion.Name = "cant_minutos_simulacion";
            cant_minutos_simulacion.Size = new Size(65, 27);
            cant_minutos_simulacion.TabIndex = 27;
            cant_minutos_simulacion.Value = new decimal(new int[] { 480, 0, 0, 0 });
            // 
            // button2
            // 
            button2.Location = new Point(212, 409);
            button2.Name = "button2";
            button2.Size = new Size(162, 29);
            button2.TabIndex = 28;
            button2.Text = "Segunda Simulacion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(343, 299);
            label17.Name = "label17";
            label17.Size = new Size(238, 24);
            label17.TabIndex = 29;
            label17.Text = "Tiempo de viaje vacio (sim. 2)";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(360, 335);
            label18.Name = "label18";
            label18.Size = new Size(65, 20);
            label18.TabIndex = 30;
            label18.Text = "Minutos:";
            // 
            // cant_minutos_viaje_vacio
            // 
            cant_minutos_viaje_vacio.Location = new Point(431, 333);
            cant_minutos_viaje_vacio.Name = "cant_minutos_viaje_vacio";
            cant_minutos_viaje_vacio.Size = new Size(47, 27);
            cant_minutos_viaje_vacio.TabIndex = 31;
            cant_minutos_viaje_vacio.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cant_minutos_viaje_vacio);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(button2);
            Controls.Add(cant_minutos_simulacion);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(cant_minutos_viaje);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(costo_auto);
            Controls.Add(label12);
            Controls.Add(precio_auto);
            Controls.Add(precio_vagon);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(espera_auto);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(cant_minutos2);
            Controls.Add(cant_autos2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(cant_minutos1);
            Controls.Add(cant_autos1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)cant_autos1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cant_minutos1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cant_minutos2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cant_autos2).EndInit();
            ((System.ComponentModel.ISupportInitialize)espera_auto).EndInit();
            ((System.ComponentModel.ISupportInitialize)precio_vagon).EndInit();
            ((System.ComponentModel.ISupportInitialize)precio_auto).EndInit();
            ((System.ComponentModel.ISupportInitialize)costo_auto).EndInit();
            ((System.ComponentModel.ISupportInitialize)cant_minutos_viaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)cant_minutos_simulacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)cant_minutos_viaje_vacio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown cant_autos1;
        private NumericUpDown cant_minutos1;
        private NumericUpDown cant_minutos2;
        private NumericUpDown cant_autos2;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label7;
        private Label label8;
        private NumericUpDown espera_auto;
        private Label label9;
        private Label label10;
        private Label label11;
        private NumericUpDown precio_vagon;
        private NumericUpDown precio_auto;
        private Label label12;
        private NumericUpDown costo_auto;
        private Label label13;
        private Label label14;
        private NumericUpDown cant_minutos_viaje;
        private Label label15;
        private Label label16;
        private NumericUpDown cant_minutos_simulacion;
        private Button button2;
        private Label label17;
        private Label label18;
        private NumericUpDown cant_minutos_viaje_vacio;
    }
}
