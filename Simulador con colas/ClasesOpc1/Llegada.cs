using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.ClasesOpc1
{
    public class Llegada
    {
        //Cuantos autos x minuto
        private int cant_autos;
        private int cant_minutos;

        private double tiempo_entre_llegadas;
        private double prox_tiempo;

        public Llegada(int cant_autos, int cant_minutos, double tiempo_entre_llegadas, double prox_tiempo) 
        {
            this.cant_autos = cant_autos;
            this.cant_minutos = cant_minutos;
            this.tiempo_entre_llegadas = tiempo_entre_llegadas;
            this.prox_tiempo = prox_tiempo;
        }

        public int Cant_autos { get { return cant_autos; } set { cant_autos = value; } }
        public int Cant_minutos { get { return cant_minutos; } set { cant_minutos = value; } }
        public double Tiempo_entre_llegadas { get { return tiempo_entre_llegadas; } set { tiempo_entre_llegadas = value; } }
        public double Prox_tiempo { get { return prox_tiempo; } set { prox_tiempo = value; } }
    }
}
