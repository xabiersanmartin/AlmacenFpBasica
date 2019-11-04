using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Producto
    {
        public int codigoProducto { get; set; }
        public string descripcion { get; set; }
        public string talla { get; set; }
        public int stock { get; set; }
        public decimal precio { get; set; }

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
