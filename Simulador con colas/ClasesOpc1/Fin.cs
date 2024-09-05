using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.ClasesOpc1
{
    public class Fin
    {
        private double prox_tiempo = 0;
        private int cant_minutos_viaje;
        private int cant_minutos_viaje_vacio;
        private int parada_destino;
        public Fin(int cant_minutos_viaje, int cant_minutos_viaje_vacio) 
        {
            this.cant_minutos_viaje = cant_minutos_viaje;
            this.cant_minutos_viaje_vacio = cant_minutos_viaje_vacio;
            
        }    

        public double Prox_tiempo { get { return prox_tiempo; } set { prox_tiempo = value; } }
        public int Cant_minutos_viaje { get { return cant_minutos_viaje; } set { cant_minutos_viaje = value; } }
        public int Cant_minutos_viaje_vacio { get { return cant_minutos_viaje_vacio; } set { cant_minutos_viaje_vacio = value; } }
        public int Parada_destino { get { return parada_destino; } set { parada_destino = value; } }
    }
}
