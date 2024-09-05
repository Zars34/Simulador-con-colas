using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.ClasesOpc1
{
    public class Fila
    {
        /*
         Clases:
            Auto()
            Vagon(listaAutos) Tres estados: EnParada1, EnParada2, Navegando
            Parada(colaAutos)
            LlegadaAuto()
            FinParada()

         Eventos:
            LlegadaAuto
            FinParada1
            FinParada2

        Funciones:
            GenerarLlegadaAuto()
            LlegadaAuto()
            GenerarFinParada()
            FinParada()
            RevisarEsperaAutos()
            
         
         Vagon espera a que llegen los autos; en cada llegada lo va dejando en su cola de autos; una vez que una Llegada determina que la cola de autos
        del vagon es igual a 5 y que su estado es igual al de la parada donde estan se activa la funcion ComenzarViaje(), la cual cambia el estado
        del vagon a "navegando" y genera un fin; una vez que ocurre el fin, vacia la cola de autos y cambia su estado a la parada a la que llegó
        Dentro de la funcion FinParada() ademas revisará la cola de la parada; si hay 5 o mas autos carga los primeros 5 e inmediatamente vuelve a
        ejecutar la funcion ComenzarParada().
         
         
         */
        private int nro_fila;
        private string evento;
        private double reloj;

        private Llegada llegada_auto1;
        private Llegada llegada_auto2;

        private Fin fin_parada;

        private Parada parada1;
        private Parada parada2;

        private Vagon vagon;

        private int dinero;

        //Donde se guardan los clientes temporales (autos)
        private List<Auto> lista_autos = new List<Auto> { };

        public Fila(int nro_fila, string evento, double reloj, int dinero)
        {
            this.nro_fila = nro_fila;
            this.evento = evento;
            this.reloj = reloj;
            this.dinero = dinero;
        }

        //Debe retornar la fila resultante
        public static Fila GenerarFila(int cant_autos1, int cant_minutos1, int cant_autos2, int cant_minutos2, int costo_auto, int precio_vagon, int precio_auto, 
            int cant_minutos_viaje, int cant_minutos_viaje_vacio)
        {
            //CAMBIAR ESTO LUEGO
            Fila fila = new Fila(0, "Inicializacion", 0, 0);

            fila.llegada_auto1 = new Llegada(cant_autos1, cant_minutos1, 0, 0);
            fila.llegada_auto2 = new Llegada(cant_autos2, cant_minutos2, 0, 0);

            fila.fin_parada = new Fin(cant_minutos_viaje, cant_minutos_viaje_vacio);


            fila.parada1 = new Parada(0);
            fila.parada2 = new Parada(1);

            fila.vagon = new Vagon("En espera 1");

            return fila;
        }

        public int Nro_fila { get { return nro_fila; } set { nro_fila = value; } }
        public string Evento { get { return evento; } set { evento = value; } }
        public double Reloj { get { return reloj; } set { reloj = value; } }
        public Llegada Llegada_auto1 { get { return llegada_auto1; } set { llegada_auto1 = value; } }
        public Llegada Llegada_auto2 { get { return llegada_auto2; } set { llegada_auto2 = value; } }
        public Fin Fin_parada { get { return fin_parada; } set { fin_parada = value; } }
        public Parada Parada1 { get { return parada1; } set { parada1 = value; } }
        public Parada Parada2 { get {return parada2; } set { parada2 = value; } }
        public Vagon Vagon { get { return vagon; } set { vagon = value; } } 
        public int Dinero { get { return dinero; } set { dinero = value; } }
        public List<Auto> Lista_autos { get { return lista_autos; } set { lista_autos = value; } }

    }
}
