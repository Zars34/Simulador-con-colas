using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.ClasesOpc1
{
    public class Auto
    {
        private string estado;
        private int nro_fila;
        private double? tiempoInicio;
        private double? tiempoLimite;
        private int parada;

        public Auto(string estado, int nro_fila, double tiempoInicio, double tiempoLimite, int parada)
        {
            this.estado = estado;
            this.nro_fila = nro_fila;
            this.tiempoInicio = tiempoInicio;
            this.tiempoLimite = tiempoLimite;
            this.parada = parada;
        }

        public string Estado {  get { return estado; } set { estado = value; } }
        public int Nro_fila { get { return nro_fila; } set {  nro_fila = value; } }
        public double? TiempoInicio { get { return tiempoInicio; } set { tiempoInicio = value; } }
        public double? TiempoLimite { get { return tiempoLimite; } set { tiempoLimite= value; } }
        public int Parada { get { return parada; } set { parada = value; } }
    }
}
