using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using CapaDatos;

namespace CapaAcceso
{
    public class Acceso
    {
        #region Propiedades para la conexion de la base de datos
        private const string DBName = "almacen.bd";
        private const string SQLScript = @"..\script.sql";
        private static bool IsDbRecentlyCreated = false;
        #endregion

        /// <summary>
        ///Metodo que crea la base de datos si no existe
        /// </summary>
        public static void Up()
        {
            if (!File.Exists(Path.GetFullPath(DBName)))
            {
                SQLiteConnection.CreateFile(DBName);
                IsDbRecentlyCreated = true;
            }

            using (var ctx = GetInstance())
            {
                if (IsDbRecentlyCreated)
                {
                    using (var reader = new StreamReader(Path.GetFullPath(SQLScript)))
                    {
                        var query = "";
                        var line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            query += line;
                        }

                        using (var command = new SQLiteCommand(query, ctx))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    }
                }
            }

        /// <summary>
        /// Metodo para abrir la conexion de la base de datos
        /// </summary>
        /// <returns></returns>
        public static SQLiteConnection GetInstance()
        {
            var db = new SQLiteConnection(
                string.Format("Data Source={0};Version=3;", DBName)
            );

            db.Open();

            return db;
        }


        #region Funciones para el administrador
        /// <summary>
        /// Funcion que devuelve el administrador
        /// </summary>
        /// <param name="msg"></param>
        /// <returns>Retorna el administrador, o null en su defecto</returns>
        public Adminstrador DevolverAdmin(out string msg)
        {
            msg = "";
            try
            {
                using (var con = GetInstance())
                {

                    var query = "SELECT * FROM ADMINISTRADOR";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    using (SQLiteDataReader dradmin = cmd.ExecuteReader())
                    {
                        while (dradmin.Read())
                        {
                            Adminstrador newAdmin = new Adminstrador();
                            newAdmin.nombre = dradmin["Nombre"].ToString();
                            newAdmin.password = dradmin["Password"].ToString();
                            return newAdmin;
                        }

                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                msg = e.Message;

            }
            return null;

        }
        /// <summary>
        /// Funcion que mdifica la contraseña del administrador
        /// </summary>
        /// <param name="nuevoNombre"></param>
        /// <returns>Retorna "", o un mensaje de error en su defecto</returns>
        public String ModificarPassAdmin(string nuevoNombre)
        {
            try
            {
                using (var con = GetInstance())
                {

                    var query = "UPDATE administrador Set administrador.Password @Password";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre",nuevoNombre);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                return e.Message;

            }
            return "";
        }
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
