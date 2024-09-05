namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form_2 = new Form2((int)cant_autos1.Value, (int)cant_minutos1.Value, (int)cant_autos2.Value, (int)cant_minutos2.Value, (int)espera_auto.Value, (int)costo_auto.Value, (int)precio_vagon.Value, 
                (int)precio_auto.Value, (int)cant_minutos_viaje.Value, (int)cant_minutos_viaje_vacio.Value, (int)cant_minutos_simulacion.Value);
            form_2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form_3 = new Form3((int)cant_autos1.Value, (int)cant_minutos1.Value, (int)cant_autos2.Value, (int)cant_minutos2.Value, (int)espera_auto.Value, (int)costo_auto.Value, (int)precio_vagon.Value, 
                (int)precio_auto.Value, (int)cant_minutos_viaje.Value, (int)cant_minutos_viaje_vacio.Value, (int)cant_minutos_simulacion.Value);
            form_3.Show();
        }
    }
}
