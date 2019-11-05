using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class TiposMedidas
    {
        
        public string Kilos { get; set; }
        public string Litros { get; set; }
        public enum Tallas { grande,mediana,pequeña}
        public Tallas Talla { get; set; }

        public TiposMedidas(string litros)
        {
            Litros = litros;
        }

        public TiposMedidas(Tallas talla)
        {
            Talla = talla;
        }

    }
}
