namespace WinFormsApp1
{
    partial class Form2
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
            grilla = new DataGridView();
            nro_fila_grilla = new DataGridViewTextBoxColumn();
            evento_grilla = new DataGridViewTextBoxColumn();
            reloj_grilla = new DataGridViewTextBoxColumn();
            tiempo_entre_llegadas1_grilla = new DataGridViewTextBoxColumn();
            prox_tiempo_llegada1_grilla = new DataGridViewTextBoxColumn();
            tiempo_entre_llegadas2_grilla = new DataGridViewTextBoxColumn();
            prox_tiempo_llegada2_grilla = new DataGridViewTextBoxColumn();
            prox_tiempo_fin_parada_grilla = new DataGridViewTextBoxColumn();
            estado_vagon_grilla = new DataGridViewTextBoxColumn();
            cant_autos_vagon_grilla = new DataGridViewTextBoxColumn();
            cola_parada1_grilla = new DataGridViewTextBoxColumn();
            cola_parada2_grilla = new DataGridViewTextBoxColumn();
            cant_dinero_grilla = new DataGridViewTextBoxColumn();
            label1 = new Label();
            duracion_viaje_vagon_label = new Label();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // grilla
            // 
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Columns.AddRange(new DataGridViewColumn[] { nro_fila_grilla, evento_grilla, reloj_grilla, tiempo_entre_llegadas1_grilla, prox_tiempo_llegada1_grilla, tiempo_entre_llegadas2_grilla, prox_tiempo_llegada2_grilla, prox_tiempo_fin_parada_grilla, estado_vagon_grilla, cant_autos_vagon_grilla, cola_parada1_grilla, cola_parada2_grilla, cant_dinero_grilla });
            grilla.Location = new Point(12, 91);
            grilla.Name = "grilla";
            grilla.RowHeadersWidth = 51;
            grilla.Size = new Size(1390, 688);
            grilla.TabIndex = 0;
            // 
            // nro_fila_grilla
            // 
            nro_fila_grilla.FillWeight = 10F;
            nro_fila_grilla.HeaderText = "Nro. Fila";
            nro_fila_grilla.MinimumWidth = 6;
            nro_fila_grilla.Name = "nro_fila_grilla";
            nro_fila_grilla.Width = 125;
            // 
            // evento_grilla
            // 
            evento_grilla.FillWeight = 10F;
            evento_grilla.HeaderText = "Evento";
            evento_grilla.MinimumWidth = 6;
            evento_grilla.Name = "evento_grilla";
            evento_grilla.Width = 125;
            // 
            // reloj_grilla
            // 
            reloj_grilla.FillWeight = 10F;
            reloj_grilla.HeaderText = "Reloj";
            reloj_grilla.MinimumWidth = 6;
            reloj_grilla.Name = "reloj_grilla";
            reloj_grilla.Width = 125;
            // 
            // tiempo_entre_llegadas1_grilla
            // 
            tiempo_entre_llegadas1_grilla.HeaderText = "Tiempo entre Llegadas 1";
            tiempo_entre_llegadas1_grilla.MinimumWidth = 6;
            tiempo_entre_llegadas1_grilla.Name = "tiempo_entre_llegadas1_grilla";
            tiempo_entre_llegadas1_grilla.Width = 125;
            // 
            // prox_tiempo_llegada1_grilla
            // 
            prox_tiempo_llegada1_grilla.HeaderText = "Prox. Tiempo Llegada Auto 1";
            prox_tiempo_llegada1_grilla.MinimumWidth = 6;
            prox_tiempo_llegada1_grilla.Name = "prox_tiempo_llegada1_grilla";
            prox_tiempo_llegada1_grilla.Width = 125;
            // 
            // tiempo_entre_llegadas2_grilla
            // 
            tiempo_entre_llegadas2_grilla.HeaderText = "Tiempo entre Llegadas 2";
            tiempo_entre_llegadas2_grilla.MinimumWidth = 6;
            tiempo_entre_llegadas2_grilla.Name = "tiempo_entre_llegadas2_grilla";
            tiempo_entre_llegadas2_grilla.Width = 125;
            // 
            // prox_tiempo_llegada2_grilla
            // 
            prox_tiempo_llegada2_grilla.HeaderText = "Prox. Tiempo Llegada Auto 2";
            prox_tiempo_llegada2_grilla.MinimumWidth = 6;
            prox_tiempo_llegada2_grilla.Name = "prox_tiempo_llegada2_grilla";
            prox_tiempo_llegada2_grilla.Width = 125;
            // 
            // prox_tiempo_fin_parada_grilla
            // 
            prox_tiempo_fin_parada_grilla.HeaderText = "Prox. Tiempo Fin Parada";
            prox_tiempo_fin_parada_grilla.MinimumWidth = 6;
            prox_tiempo_fin_parada_grilla.Name = "prox_tiempo_fin_parada_grilla";
            prox_tiempo_fin_parada_grilla.Width = 125;
            // 
            // estado_vagon_grilla
            // 
            estado_vagon_grilla.HeaderText = "Estado Vagon";
            estado_vagon_grilla.MinimumWidth = 6;
            estado_vagon_grilla.Name = "estado_vagon_grilla";
            estado_vagon_grilla.Width = 125;
            // 
            // cant_autos_vagon_grilla
            // 
            cant_autos_vagon_grilla.HeaderText = "Cant. Autos Vagon";
            cant_autos_vagon_grilla.MinimumWidth = 6;
            cant_autos_vagon_grilla.Name = "cant_autos_vagon_grilla";
            cant_autos_vagon_grilla.Width = 125;
            // 
            // cola_parada1_grilla
            // 
            cola_parada1_grilla.HeaderText = "Cola Parada 1";
            cola_parada1_grilla.MinimumWidth = 6;
            cola_parada1_grilla.Name = "cola_parada1_grilla";
            cola_parada1_grilla.Width = 125;
            // 
            // cola_parada2_grilla
            // 
            cola_parada2_grilla.HeaderText = "Cola Parada 2";
            cola_parada2_grilla.MinimumWidth = 6;
            cola_parada2_grilla.Name = "cola_parada2_grilla";
            cola_parada2_grilla.Width = 125;
            // 
            // cant_dinero_grilla
            // 
            cant_dinero_grilla.HeaderText = "Cant. Dinero";
            cant_dinero_grilla.MinimumWidth = 6;
            cant_dinero_grilla.Name = "cant_dinero_grilla";
            cant_dinero_grilla.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(224, 31);
            label1.TabIndex = 1;
            label1.Text = "Primera Simulacion";
            // 
            // duracion_viaje_vagon_label
            // 
            duracion_viaje_vagon_label.AutoSize = true;
            duracion_viaje_vagon_label.Location = new Point(277, 37);
            duracion_viaje_vagon_label.Name = "duracion_viaje_vagon_label";
            duracion_viaje_vagon_label.Size = new Size(194, 20);
            duracion_viaje_vagon_label.TabIndex = 2;
            duracion_viaje_vagon_label.Text = "Duracion de viaje de vagon:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 802);
            Controls.Add(duracion_viaje_vagon_label);
            Controls.Add(label1);
            Controls.Add(grilla);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grilla;
        private Label label1;
        private Label duracion_viaje_vagon_label;
        private DataGridViewTextBoxColumn nro_fila_grilla;
        private DataGridViewTextBoxColumn evento_grilla;
        private DataGridViewTextBoxColumn reloj_grilla;
        private DataGridViewTextBoxColumn tiempo_entre_llegadas1_grilla;
        private DataGridViewTextBoxColumn prox_tiempo_llegada1_grilla;
        private DataGridViewTextBoxColumn tiempo_entre_llegadas2_grilla;
        private DataGridViewTextBoxColumn prox_tiempo_llegada2_grilla;
        private DataGridViewTextBoxColumn prox_tiempo_fin_parada_grilla;
        private DataGridViewTextBoxColumn estado_vagon_grilla;
        private DataGridViewTextBoxColumn cant_autos_vagon_grilla;
        private DataGridViewTextBoxColumn cola_parada1_grilla;
        private DataGridViewTextBoxColumn cola_parada2_grilla;
        private DataGridViewTextBoxColumn cant_dinero_grilla;
    }
}