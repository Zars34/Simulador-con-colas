using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.ClasesOpc1
{
    public class Vagon
    {
        public List<Auto> lista_autos = new List<Auto> { };
        public string estado;

        public Vagon(string estado)
        {
            this.estado = estado;
        }

        public string Estado {  get { return estado; } set { estado = value; } }
        public List<Auto> Lista_autos { get { return lista_autos; } set { lista_autos = value; } }
    }
}
