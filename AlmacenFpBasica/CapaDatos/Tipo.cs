using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Tipo
    {
 
        public string NombreTipo { get; set; }
        public int CodTipo { get; set; }
        public Tipo()
        {

        }

        public Tipo(string nombreTipo, int codTipo) : this(nombreTipo)
        {
            CodTipo = codTipo;
        }

        public Tipo(string nombreTipo)
        {
            NombreTipo = nombreTipo;
        }
    }
}
