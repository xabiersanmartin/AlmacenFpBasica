using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Tipo
    {
        public enum TiposProducto { solido, liquido, ropa }
        public TiposProducto TipoProducto { get; set; }
        public Tipo()
        {
        }
        public Tipo(TiposProducto tipoProducto)
        {
            TipoProducto = tipoProducto;
        }
    }
}
