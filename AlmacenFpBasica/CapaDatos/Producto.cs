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
        public int codigoCategoria { get; set; }
        public int codigoSubcategoria { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public decimal precio { get; set; }

        public Producto()
        {
        }

        public Producto(string descripcion, int stock, decimal precio)
        {
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }

        public Producto(int codigoProducto, string descripcion, int stock, decimal precio)
        {
            this.codigoProducto = codigoProducto;
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }

        public Producto(int codigoProducto, int codigoCategoria, int codigoSubcategoria, string descripcion, int stock, decimal precio)
        {
            this.codigoProducto = codigoProducto;
            this.codigoCategoria = codigoCategoria;
            this.codigoSubcategoria = codigoSubcategoria;
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
        }
    }
}
