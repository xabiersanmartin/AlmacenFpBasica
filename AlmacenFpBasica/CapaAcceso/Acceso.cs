using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace CapaAcceso
{
    public class Acceso
    {
        private const string DBName = "almacen.bd";
        private const string SQLScript = @"..\CapaPresentacion\bin\debug\almacen.bd";
        private static bool IsDbRecentlyCreated = false;
       
        
        #region Funciones para el administrador
        //TODO CargarAdministrador
        //TODO ModificarPasswordAdministrador
        #endregion

        #region Funciones para la empresa
        //TODO CargarEmpresa
        //TODO ModificarEmpresa
        #endregion

        #region Funciones para las categorias
        //TODO CargarCategorias
        //TODO AñadirCategoria (Admin)
        //TODO ModificarCategoria (Admin)
        //TODO EliminarCategoria (Admin)
        #endregion

        #region Funciones para las subcategorias
        //TODO CargarSubCategorias
        //TODO AñadirSubCategoria (Admin)
        //TODO ModificarSubCategoria (Admin)
        //TODO EliminarSubCategoria (Admin)
        #endregion

        #region Funciones para los productos
        //TODO CargarProductos
        //TODO ModificarProducto
        //TODO AñadirProducto (Admin)
        //TODO EliminarProducto (Admin)
        #endregion


      
    }
}
