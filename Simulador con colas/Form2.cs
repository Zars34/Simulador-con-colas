using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.ClasesOpc1;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        //Para los parametros de Parada1
        private int cant_autos1;
        private int cant_minutos1;
        

        //Para los parametros de Parada1
        private int cant_autos2;
        private int cant_minutos2;

        //Para los autos que se van
        private int espera_auto;
        private int costo_auto;

        //Para los precios
        private int precio_vagon;
        private int precio_auto;

        //Para saber cuanto dura el recorrido
        private int cant_minutos_viaje;
        private int cant_minutos_viaje_vacio;

        //Hasta cuando se realiza la simulacion
        private double cant_minutos_simulacion;

        //Para determinar si el vagon esta navegando o no
        private bool esta_navegando = false;

        


        public Form2(int cant_autos1, int cant_minutos1, int cant_autos2, int cant_minutos2, int espera_auto, int costo_auto, int precio_vagon, int precio_auto, int cant_minutos_viaje, int cant_minutos_viaje_vacio, int cant_minutos_simulacion)
        {
            InitializeComponent();
            this.cant_autos1 = cant_autos1;
            this.cant_minutos1 = cant_minutos1;
            this.cant_autos2 = cant_autos2;
            this.cant_minutos2 = cant_minutos2;
            this.espera_auto = espera_auto;
            this.costo_auto = costo_auto;
            this.precio_vagon = precio_vagon;
            this.precio_auto = precio_auto;
            this.cant_minutos_viaje = cant_minutos_viaje;
            this.cant_minutos_simulacion = cant_minutos_simulacion;
            this.Load += new EventHandler(Form2_Load);
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            duracion_viaje_vagon_label.Text = "Duracion de viaje de vagon: " + cant_minutos_viaje + " minutos";

            Fila fila = Fila.GenerarFila(cant_autos1, cant_minutos1, cant_autos2, cant_minutos2, costo_auto, precio_vagon, precio_auto, cant_minutos_viaje, cant_minutos_viaje_vacio);
            GenerarLlegada(fila, 0);
            GenerarLlegada(fila, 1);

            LlenarFilaGrilla(fila, 0);

            FuncionCiclica(fila);
        }

        public void FuncionCiclica(Fila fila)
        {
            //Algunas banderas de ayuda
            bool esLlegada = false;
            bool esFin = false;
            bool esFinalSimulacion = false;
            bool esSalidaAuto = false;

            //Para elegir el siguiente evento
            double prox_tiempo = 1000000000;
            string prox_evento = "";
            int parada_auto;

            if(fila.Reloj <= cant_minutos_simulacion)
            {
                //Revisa los tiempos de las llegadas
                if(fila.Llegada_auto1.Prox_tiempo < fila.Llegada_auto2.Prox_tiempo)
                {
                    esLlegada = true;
                    esFin = false;
                    prox_evento = "Llegada Auto 1";
                    prox_tiempo = Math.Round(fila.Llegada_auto1.Prox_tiempo, 3);
                    parada_auto = 0;
                } else
                {
                    esLlegada = true;
                    esFin = false;
                    prox_evento = "Llegada Auto 2";
                    prox_tiempo = Math.Round(fila.Llegada_auto2.Prox_tiempo, 3);
                    parada_auto = 1;
                }

                //Revisa el tiempo del fin
                if(fila.Fin_parada.Prox_tiempo < prox_tiempo && fila.Fin_parada.Prox_tiempo > 0)
                {
                    esLlegada = false;
                    esFin = true;
                    prox_evento = "Fin de parada";
                    prox_tiempo = Math.Round(fila.Fin_parada.Prox_tiempo, 3);
                }

                //Revisar cuando termina la simulacion
                if(cant_minutos_simulacion < prox_tiempo)
                {
                    esFinalSimulacion = true;
                    prox_evento = "Simulacion Terminada";
                    prox_tiempo = Math.Round(cant_minutos_simulacion, 3);
                }

                List<Auto> lista_autos_eliminar = new List<Auto> { };


                foreach (var auto in fila.Lista_autos)
                {
                    if(auto.TiempoLimite < prox_tiempo && (auto.Estado == "En parada 1" || auto.Estado == "En parada 2"))
                    {
                        esLlegada = false;
                        esFin = false;
                        esSalidaAuto = true;
                        prox_evento = "Auto " + auto.Nro_fila + " se retira";
                        prox_tiempo = (double)auto.TiempoLimite;

                        if (auto.Parada == 0)
                        {
                            fila.Parada1.Cola_autos.Remove(auto);
                        }
                        else
                        {
                            fila.Parada2.Cola_autos.Remove(auto);
                        }

                        if (auto != null)
                        {
                            lista_autos_eliminar.Add(auto);
                        }

                        fila.Dinero -= 1;
                    }
                }

                if (lista_autos_eliminar.Count != 0)
                {
                    foreach (var auto in lista_autos_eliminar)
                    {
                        if (fila.Lista_autos.Contains(auto) && auto != null)
                        {
                            fila.Lista_autos.Remove(auto);
                        }
                    }
                }

                /*
                List<Auto> lista_autos_eliminar = new List<Auto> { };

                //Revisa la espera de los autos
                foreach (var auto in fila.Lista_autos)
                {
                    Auto auto_borrar = RevisarEsperaAuto(fila, auto, prox_tiempo);
                    if(auto_borrar != null)
                    {
                        lista_autos_eliminar.Add(auto_borrar);
                    }
                }*/


                fila.Nro_fila += 1;
                fila.Evento = prox_evento;
                fila.Reloj = prox_tiempo;

                lista_autos_eliminar.Clear();

                //Determina el siguiente evento
                if (esLlegada)
                {
                    LlegadaAuto(fila, parada_auto);

                    // Crear la columna para el estado del auto
                    DataGridViewColumn columna_auto_estado = new DataGridViewColumn();
                    columna_auto_estado.Name = "auto_estado_grilla" + fila.Nro_fila;
                    columna_auto_estado.HeaderText = "Estado " + fila.Nro_fila;
                    columna_auto_estado.DataPropertyName = "auto_estado_grilla" + fila.Nro_fila;
                    columna_auto_estado.CellTemplate = new DataGridViewTextBoxCell();
                    columna_auto_estado.FillWeight = 10; // Ajustar FillWeight según sea necesario

                    // Crear la columna para el tiempo de inicio del auto
                    DataGridViewColumn columna_auto_tiempo_inicio = new DataGridViewColumn();
                    columna_auto_tiempo_inicio.Name = "auto_tiempo_inicio_grilla" + fila.Nro_fila;
                    columna_auto_tiempo_inicio.HeaderText = "Tiempo Inicio " + fila.Nro_fila;
                    columna_auto_tiempo_inicio.DataPropertyName = "auto_tiempo_inicio_grilla" + fila.Nro_fila;
                    columna_auto_tiempo_inicio.CellTemplate = new DataGridViewTextBoxCell();
                    columna_auto_tiempo_inicio.FillWeight = 10; // Ajustar FillWeight según sea necesario

                    // Agregar las columnas al DataGridView
                    grilla.Columns.Add(columna_auto_estado);
                    grilla.Columns.Add(columna_auto_tiempo_inicio);

                }

                if(esFin)
                {
                    FinParada(fila);
                }


                LlenarFilaGrilla(fila, fila.Nro_fila);

                foreach (var auto in fila.Lista_autos)
                {
                    if (grilla.Columns.Contains("auto_estado_grilla" + auto.Nro_fila))
                    {
                        grilla.Rows[fila.Nro_fila].Cells["auto_estado_grilla" + auto.Nro_fila].Value = auto.Estado;
                        grilla.Rows[fila.Nro_fila].Cells["auto_tiempo_inicio_grilla" + auto.Nro_fila].Value = auto.TiempoLimite;
                    }
                }
                

                Fila fila2 = fila;

                if (esFinalSimulacion)
                {
                    return;
                }

                FuncionCiclica(fila2);
            }


        }


        //Tip: Las 2 columnas de los autos se agregan cuando se asegura que el evento es de llegada;
        //  pero los datos se muestran cuando se realiza el metodo LlenarFilaGrilla() (después)
        public void LlenarFilaGrilla(Fila fila, int nro_fila)
        {

            grilla.Rows.Add();

            grilla.Rows[nro_fila].Cells["nro_fila_grilla"].Value = nro_fila;
            grilla.Rows[nro_fila].Cells["evento_grilla"].Value = fila.Evento;
            grilla.Rows[nro_fila].Cells["reloj_grilla"].Value = fila.Reloj;
            grilla.Rows[nro_fila].Cells["tiempo_entre_llegadas1_grilla"].Value = Math.Round(fila.Llegada_auto1.Tiempo_entre_llegadas, 3);
            grilla.Rows[nro_fila].Cells["prox_tiempo_llegada1_grilla"].Value = Math.Round(fila.Llegada_auto1.Prox_tiempo, 3);
            grilla.Rows[nro_fila].Cells["tiempo_entre_llegadas2_grilla"].Value = Math.Round(fila.Llegada_auto2.Tiempo_entre_llegadas, 3);
            grilla.Rows[nro_fila].Cells["prox_tiempo_llegada2_grilla"].Value = Math.Round(fila.Llegada_auto2.Prox_tiempo, 3);
            grilla.Rows[nro_fila].Cells["prox_tiempo_fin_parada_grilla"].Value = Math.Round(fila.Fin_parada.Prox_tiempo, 3);
            grilla.Rows[nro_fila].Cells["estado_vagon_grilla"].Value = fila.Vagon.Estado;
            grilla.Rows[nro_fila].Cells["cant_autos_vagon_grilla"].Value = fila.Vagon.Lista_autos.Count;
            grilla.Rows[nro_fila].Cells["cola_parada1_grilla"].Value = fila.Parada1.Cola_autos.Count;
            grilla.Rows[nro_fila].Cells["cola_parada2_grilla"].Value = fila.Parada2.Cola_autos.Count;
            grilla.Rows[nro_fila].Cells["cant_dinero_grilla"].Value = fila.Dinero;


        }

        public void GenerarLlegada(Fila fila, int nro_parada)
        {
            if(nro_parada == 0)
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                double frecuencia = fila.Llegada_auto1.Cant_autos / fila.Llegada_auto1.Cant_minutos;
                double media = 1 / frecuencia;

                double tiempo_entre_llegadas = -(media * Math.Log(1 - (double)random.NextDouble()));
                tiempo_entre_llegadas = Math.Round(tiempo_entre_llegadas, 2);

                fila.Llegada_auto1.Tiempo_entre_llegadas = tiempo_entre_llegadas;
                fila.Llegada_auto1.Prox_tiempo = fila.Reloj + tiempo_entre_llegadas;
            } else
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                double valor_random = random.NextDouble();
                if (valor_random == 1.0) 
                {
                    valor_random = 0.9999999999;
                }

                double frecuencia = (double)fila.Llegada_auto2.Cant_autos / (double)fila.Llegada_auto2.Cant_minutos;
                double media = 1 / frecuencia;

                double tiempo_entre_llegadas = -(media * Math.Log(1 - valor_random));
                tiempo_entre_llegadas = Math.Round(tiempo_entre_llegadas, 2);

                /*MessageBox.Show("autos: " + fila.Llegada_auto2.Cant_autos + " minutos: " + fila.Llegada_auto2.Cant_minutos  + 
                    " frecuencia: " + frecuencia + " media: " + media + " tiempo entre llegadas " + tiempo_entre_llegadas);*/

                fila.Llegada_auto2.Tiempo_entre_llegadas = tiempo_entre_llegadas;
                fila.Llegada_auto2.Prox_tiempo = fila.Reloj + tiempo_entre_llegadas;
            }
        }

        public void LlegadaAuto(Fila fila, int nro_parada)
        {
            bool barco_espera = true;

            if(nro_parada == 0)
            {

                Auto autoTemporal = new Auto("En parada 1", fila.Nro_fila, fila.Reloj, fila.Reloj + espera_auto, nro_parada);

                fila.Lista_autos.Add(autoTemporal);

                if (fila.Vagon.Estado == "En espera 1")
                {
                    if (fila.Vagon.lista_autos.Count < 5)
                    {
                        autoTemporal.Estado = "En vagon";
                        fila.Vagon.lista_autos.Add(autoTemporal);
                    }
                }
                else
                {
                    fila.Parada1.Cola_autos.Add(autoTemporal);
                }

                if (fila.Vagon.lista_autos.Count == 5 && barco_espera && !esta_navegando)
                {
                    GenerarFinParada(fila, 1);
                    barco_espera = false;
                }
                

                GenerarLlegada(fila, nro_parada);  
            }
            else
            {

                Auto autoTemporal = new Auto("En parada 2", fila.Nro_fila, fila.Reloj, fila.Reloj + espera_auto, nro_parada);

                fila.Lista_autos.Add(autoTemporal);

                if (fila.Vagon.Estado == "En espera 2")
                {
                    if (fila.Vagon.lista_autos.Count < 5)
                    {
                        autoTemporal.Estado = "En vagon";
                        fila.Vagon.lista_autos.Add(autoTemporal);
                    }
                }
                else
                {
                    fila.Parada2.Cola_autos.Add(autoTemporal);
                }

                if (fila.Vagon.lista_autos.Count == 5 && barco_espera && !esta_navegando)
                {
                    GenerarFinParada(fila, 0);
                    barco_espera = false;
                }

                GenerarLlegada(fila, nro_parada);

            }

        }


        public void GenerarFinParada(Fila fila, int parada_destino)
        {
            esta_navegando = true;

            if(parada_destino == 1)
            {
                fila.Vagon.Estado = "Navegando hacia 2";
                foreach (var auto in fila.Vagon.Lista_autos)
                {
                    auto.Estado = "Navegando hacia 2";
                }
                fila.Fin_parada.Prox_tiempo = fila.Reloj + fila.Fin_parada.Cant_minutos_viaje;
                fila.Fin_parada.Parada_destino = parada_destino;

                fila.Dinero += 4;
            } else
            {
                fila.Vagon.Estado = "Navegando hacia 1";
                foreach (var auto in fila.Vagon.Lista_autos)
                {
                    auto.Estado = "Navegando hacia 1";
                }
                fila.Fin_parada.Prox_tiempo = fila.Reloj + fila.Fin_parada.Cant_minutos_viaje;
                fila.Fin_parada.Parada_destino = parada_destino;

                fila.Dinero += 4;
            }
            
        }


        public void FinParada(Fila fila)
        {
            esta_navegando = false;

            foreach (var auto in fila.Vagon.Lista_autos)
            {
                fila.Lista_autos.Remove(auto);
            }

            fila.Vagon.lista_autos.Clear();

            if (fila.Fin_parada.Parada_destino == 0)
            {
                fila.Vagon.Estado = "En espera 1";

                if(fila.Parada1.Cola_autos.Count != 0 )
                {
                    int cant_max_iteraciones = Math.Min(5, fila.Parada1.Cola_autos.Count);

                    for(int i = 0; i < cant_max_iteraciones; i++)
                    {
                        Auto auto = fila.Parada1.Cola_autos[0];
                        fila.Parada1.Cola_autos.RemoveAt(0);
                        auto.Estado = "En vagon";
                        fila.Vagon.Lista_autos.Add(auto);
                    }

                    if(fila.Vagon.Lista_autos.Count == 5)
                    {
                        GenerarFinParada(fila, 1);
                    }

                }
            }
            else
            {
                fila.Vagon.Estado = "En espera 2";

                if (fila.Parada2.Cola_autos.Count != 0)
                {
                    int cant_max_iteraciones = Math.Min(5, fila.Parada2.Cola_autos.Count);

                    for (int i = 0; i < cant_max_iteraciones; i++)
                    {
                        Auto auto = fila.Parada2.Cola_autos[0];
                        fila.Parada2.Cola_autos.RemoveAt(0);
                        auto.Estado = "En vagon";
                        fila.Vagon.Lista_autos.Add(auto);
                    }

                    if (fila.Vagon.Lista_autos.Count == 5)
                    {
                        GenerarFinParada(fila, 0);
                    }

                }
            }

            fila.Fin_parada.Prox_tiempo = 0;
        }

        public Auto RevisarEsperaAuto(Fila fila, Auto auto, double reloj)
        {

            if (reloj > auto.TiempoLimite && (auto.Estado == "En parada 1" || auto.Estado == "En parada 2"))
            {
                Auto auto_eliminar = auto;
                if (auto.Parada == 0)
                {
                    fila.Parada1.Cola_autos.Remove(auto);
                } else
                {
                    fila.Parada2.Cola_autos.Remove(auto);
                }

                fila.Dinero -= 1;

                return auto_eliminar;
            }
            return null;
        }

        

    }
}
