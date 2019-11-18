using CapaAcceso;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaGestion
{
    public class Gestor
    {
        Acceso nuevoacces = new Acceso();

        string mensaje { get; set; }

        //Hecho
        #region Funciones para el admin
        public bool IniciarSesion(Adminstrador admin, out string mensaje)
        {
            return nuevoacces.IniciarSesion(admin, out mensaje);
        }
        public string ModificarPassAdmin(string nuevaPass)
        {
            return nuevoacces.ModificarPassAdmin(nuevaPass);
        }
        #endregion

        #region Funciones para los tipos
        public List<Tipo> CargarTipos(out string mensaje)
        {
            return nuevoacces.CargarTipos(out mensaje);
        }
        #endregion

        #region Funciones para las categorias
        public List<Categoria> CargarCategoria(out string mensaje)
        {
            return nuevoacces.CargarCategorias(out mensaje);
        }
        public string EliminarCategoria(Categoria categoria)
        {
            return nuevoacces.EliminarCategoria(categoria);
        }
        #endregion

        #region Funciones para las subcategorias
        public List<Subcategoria> CargarSubCategoria(out string mensaje)
        {
            return nuevoacces.CargarSubcategoria(out mensaje);
        }
        public string EliminarSubCategoria(Subcategoria subcategoria)
        {
            return nuevoacces.EliminarSubCategoria(subcategoria);
        }
        #endregion

        #region Funciones para los productos
        public List<Producto> CargarProductos(out string mensaje)
        {
            return nuevoacces.CargarProductos(out mensaje);
        }
        public string AnadirProducto(Producto nuevoProducto)
        {
            return nuevoacces.AnadirProducto(nuevoProducto);
        }
        public string EliminarProducto(Producto producto)
        {
            return nuevoacces.EliminarProducto(producto);
        }
        public List<Producto> BuscarProductosPorDescripcion(String descripcion, out string mensaje)
        {
            return nuevoacces.BuscarProductosPorDescripcion(descripcion, out mensaje);
        }
        #endregion
    }
}
