using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaAccesoDatos
{
    public class ProcesoAprobacion
    {
        public int NroDoc {  get; set; }
        public string TipoDoc { get; set; }
        public int Puntaje { get; set; }

        public ProcesoAprobacion() { }
        public ProcesoAprobacion(int nroDoc)
        {
            this.NroDoc = nroDoc;

        }
    }
}
