using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Producto
    {
        private int codigoProducto { get; set; }
        private string descripcion { get; set; }
        private string talla { get; set; }
        private int stock { get; set; }
        private decimal precio { get; set; }

        public Producto()
        {
        }
        public Producto(string descripcion, string talla, int stock, decimal precio)
        {
            this.descripcion = descripcion;
            this.talla = talla;
            this.stock = stock;
            this.precio = precio;
        }
        public Producto(int codigoProducto, string descripcion, string talla, int stock, decimal precio)
        {
            this.codigoProducto = codigoProducto;
            this.descripcion = descripcion;
            this.talla = talla;
            this.stock = stock;
            this.precio = precio;
        }
    }
}
