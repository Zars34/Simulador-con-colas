using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.ClasesOpc1
{
    public class Parada
    {
        private int nro_parada;
        private List<Auto> cola_autos = new List<Auto> { };

        public Parada(int nro_parada)
        {
            this.nro_parada = nro_parada;
        }

        public int Nro_parada { get { return nro_parada; } set { nro_parada = value; } }
        public List<Auto> Cola_autos { get { return cola_autos; } set { cola_autos = value; } }
    }
}
