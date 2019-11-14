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
        private const string DBName = "almacen.db";
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
        public bool IniciarSesion(Adminstrador admin, out string msg)
        {
            msg = "";
            bool exito = false;
            Adminstrador newAdmin = new Adminstrador();
            try
            {
                using (var con = GetInstance())
                {

                    var query = "SELECT * FROM ADMINISTRADOR";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    using (SQLiteDataReader dradmin = cmd.ExecuteReader())
                    {
                        if (dradmin.Read()) // ES UN IF, PORQUE SOLO ES UN CAMPO
                        {
                            
                            newAdmin.nombre = dradmin["Nombre"].ToString();
                            newAdmin.password = dradmin["Password"].ToString();
                            
                        }

                    }
                    con.Close();
                }
                if (newAdmin.Equals(admin))
                {
                    msg = "Se ha iniciado sesión correctamente";
                    exito= true;
                }
                else {
                    msg = "El nombre de administrador o contraseña son incorrectos";
                    exito= false;
                }
            }
            catch (Exception e)
            {
                msg = e.Message;

            }
            return exito;
        }
        /// <summary>
        /// Funcion que mdifica la contraseña del administradorr
        /// </summary>
        /// <param name="nuevaPass"></param>
        /// <returns>Retorna "", o un mensaje de error en su defecto</returns>
        public String ModificarPassAdmin(string nuevaPass)
        {
            try
            {
                using (var con = GetInstance())
                {

                    var query = "UPDATE administrador Set administrador.Password @Password";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@Password",nuevaPass);
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

        #region Funciones para los tipos
        /// <summary>
        /// Funcion que Carga los tipos
        /// </summary>
        /// <param name="msg">Mensaje que retorna "" si todo ha ido bien, o un error en su defecto</param>
        /// <returns>Retorna una lista con los tipos, o null en su defecto</returns>
        public List<Tipo> CargarTipos(out string msg)
        {
            msg = "";
            List<Tipo> tipos = new List<Tipo>();
            try
            {
                using (var con = GetInstance())
                {

                    var query = "SELECT * FROM TIPO";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    using (SQLiteDataReader drtipo = cmd.ExecuteReader())
                    {
                        if (!drtipo.HasRows)
                        {
                            msg = "No hay Tipos";
                            return tipos;
                        }
                        while (drtipo.Read())
                        {
                            Tipo tipo = new Tipo();
                            tipo.TipoProducto = (Tipo.TiposProducto)drtipo["Tipo"];
                            tipos.Add(tipo);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return tipos;
        }
        #endregion

        #region Funciones para las categorias
        /// <summary>
        /// Funcion que Carga las Categorias
        /// </summary>
        /// <param name="msg">Mensaje que retorna "" si todo ha ido bien, o un error en su defecto</param>
        /// <returns>Retorna una lista con las categorias, o null en su defecto</returns>
        public List<Categoria> CargarCategorias(out string msg)
        {
            msg = "";
            List<Categoria> categorias = new List<Categoria>();
            try
            {
                using (var con = GetInstance())
                {

                    var query = "SELECT * FROM categoria";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    using (SQLiteDataReader drcategoria = cmd.ExecuteReader())
                    {
                        if (!drcategoria.HasRows)
                        {
                            msg = "No hay Categorias";
                            con.Close();
                            return categorias;
                        }
                        while (drcategoria.Read())
                        {
                            Categoria categoria = new Categoria();
                            categoria.codCategoria = int.Parse(drcategoria["CodigoCategoria"].ToString());
                            categoria.codCategoria = int.Parse(drcategoria["NombreCategoria"].ToString());
                            categorias.Add(categoria);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return categorias;
        }
        //TODO AñadirCategoria (Admin)
        //TODO ModificarCategoria (Admin)
        //TODO EliminarCategoria (Admin)
        #endregion

        #region Funciones para las subcategorias

        public List<Subcategoria> CargarSubcategoria(out string msg)
        {
            List<Subcategoria> subcategorias = new List<Subcategoria>();

            try
            {
                using (var con = GetInstance())
                {
                    string SelectSubcategoria = "SELECT * FROM subcategoria;";
                    SQLiteCommand cmd = new SQLiteCommand(SelectSubcategoria, con);
                    SQLiteDataReader lector = cmd.ExecuteReader();

                    if (!lector.HasRows)
                    {
                        msg = "No hay Subcategorias";
                        con.Close();
                        return subcategorias;
                    }

                    while (lector.Read())
                    {
                        Subcategoria newSubcategoria = new Subcategoria();
                        newSubcategoria.codSubCategoria = int.Parse(lector["CodigoSubcategoria"].ToString());
                        newSubcategoria.nombreSubCategoria = lector["NombreSubcategoria"].ToString();

                        subcategorias.Add(newSubcategoria);
                    }

                    con.Close();
                    lector.Close();
                    msg = "";
                    return subcategorias;
                }
            }
            catch (Exception)
            {
                msg = "Error al cargar las Subcategorias ";
                return subcategorias;
            }
        }

        //TODO AñadirSubCategoria (Admin)
        //TODO ModificarSubCategoria (Admin)
        //TODO EliminarSubCategoria (Admin)
        #endregion

        #region Funciones para los productos
        /// <summary>
        /// Funcion que Carga los Productos
        /// </summary>
        /// <param name="msg">Mensaje que retorna "" si todo ha ido bien, o un error en su defecto</param>
        /// <returns>Retorna una lista con los Productos, o null en su defecto</returns>
        public List<Producto> CargarProductos(out string msg)
        {
            msg = "";
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var con = GetInstance())
                {

                    var query = "SELECT * FROM productos";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    using (SQLiteDataReader lector = cmd.ExecuteReader())
                    {
                        if (!lector.HasRows)
                        {
                            msg = "No hay Productos";
                            con.Close();
                            return productos;
                        }
                        while (lector.Read())
                        {
                            Producto producto = new Producto();
                            producto.codigoProducto = int.Parse(lector["CodigoProducto"].ToString());
                            producto.descripcion = lector["Descripion"].ToString();
                            producto.precio = int.Parse(lector["Precio"].ToString());
                            producto.stock = int.Parse(lector["Stock"].ToString());
                            productos.Add(producto);
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
            }
            return productos;
        }
        //TODO ModificarProducto
        //TODO AñadirProducto (Admin)
        //TODO EliminarProducto (Admin)
        #endregion

        #region Funciones para la empresa
        //TODO CargarEmpresa
        //TODO ModificarEmpresa
        #endregion

    }

}
