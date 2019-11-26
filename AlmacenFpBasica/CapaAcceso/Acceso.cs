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
        // TODO No se puede ejecutar. No 
        #region Propiedades para la conexion de la base de datos
        private const string DBName = "almacen.db";
        private const string SQLScript = @"..\..\..\script.sql";
        private static bool IsDbRecentlyCreated = false;
        #endregion

        /// <summary>
        ///Metodo que crea la base de datos si no existe
        /// </summary>
        public void Up() // TODO Este nombre no dice nada de lo que  hace el método. Y el problema de la creación o no de la BD no debe llegar a la capa de presentación, es único y exclusivo problema de la capa de Daos (y por tanto, tampoco no tiene sentido que sea público) 
        {
            if (!File.Exists(Path.GetFullPath(DBName)))
            {
                SQLiteConnection.CreateFile(DBName);
                IsDbRecentlyCreated = true;
            }

            using (var ctx = GetInstance()) // TODO No tiene sentido que haga esto si no hay que crearla. Esto debe ir en el if, y ni se necesita la variable bool
            {
                if (IsDbRecentlyCreated)
                {
                    using (var reader = new StreamReader(Path.GetFullPath(SQLScript))) // TODO Esto no crea la bd, solo el fichero vacío. Observar que no se ejecuta la consulta
                    {
                        var query = "";
                        var line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            query += line;
                        }

                        using (var command = new SQLiteCommand(query, ctx))
                        {
                            command.ExecuteNonQuery();  // TODO No se ejecuta realmente, no crea las tablas
                        }
                    }
                    }
                }
            }

        /// <summary>
        /// Metodo para abrir la conexion de la base de datos
        /// </summary>
        /// <returns></returns>
        public static SQLiteConnection GetInstance() // TODO Si da error de ejecución, SE ROMPE --> No debería ocurrir, sino que el o la usuaria debería enterarse que hay un error con un mensaje. Y de nuevo no es competencia de ninguna otra capa. Solo esta debe conocer este método
        {
            var db = new SQLiteConnection(
                string.Format("Data Source={0};Version=3;", DBName)
            );

            db.Open();

            return db;
        }

        #region Funciones para el administrador
        /// <summary>
        /// Funcion usada para iniciar sesion
        /// </summary>
        /// <param name="msg"></param>
        /// <returns>Retorna true o false y un mensaje</returns>
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
                if (newAdmin.Equals(admin)) // TODO ¡¡¡Equals solo tiene instrucción throw!!!!
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

                    var query = "UPDATE administrador Set Password = @Password";
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
            List<Tipo> tipos = new List<Tipo>();
            try
            {
                using (var con = GetInstance())
                {

                    string query = "SELECT * FROM tipo;";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    SQLiteDataReader drtipo = cmd.ExecuteReader();

                    
                        if (!drtipo.HasRows)
                        {
                            msg = "No hay Tipos";
                            con.Close();
                            return tipos;
                        }

                        while (drtipo.Read())
                        {
                            Tipo newtipo = new Tipo();
                            newtipo.NombreTipo = drtipo["Tipo"].ToString();
                            tipos.Add(newtipo);
                        }
                    
                    con.Close();
                    drtipo.Close();
                    msg = "";
                    return tipos;
                }
            }

            catch (Exception e)
            {
                msg = e.Message;
                return tipos;
            }
            
        }
        #endregion

        #region Funciones para las categorias
        /// <summary>
        /// Funcion que Carga las Categorias
        /// </summary>
        /// <param name="msg">Mensaje que retorna "" si todo ha ido bien, o un error en su defecto</param>
        /// <returns>Retorna una lista con las categorias, o null en su defecto</returns>
        public List<Categoria> CargarCategorias( out string msg)
        {
            List<Categoria> categorias = new List<Categoria>();
            try
            {
                using (var con = GetInstance())
                {
                    string query = "SELECT * FROM categoria;";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    SQLiteDataReader drcategoria = cmd.ExecuteReader();
                    
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
                            categoria.nombreCategoria = drcategoria["NombreCategoria"].ToString();
                            categorias.Add(categoria);
                        }
                    
                    con.Close();
                    drcategoria.Close();
                    msg = "";
                    return categorias;
                }
            }
            catch (Exception e)
            {
                msg = "Error al cargar las Categorias ";
                return categorias;
            }
            
        }
        /// <summary>
        /// Funcion que permite añadir una categoría
        /// </summary>
        /// <param name="categoria">Categoria que se desea añadir</param>
        /// <returns>Retorna "" si todo ha ido bien, o un mensaje de error en su defecto</returns>
        public string AñadirCategoria(Categoria categoria)
        {
            
            try
            {
                using (var con = GetInstance())
                {

                    var query = "SELECT * FROM categoria where codigoCategoria = @cod";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@cod", categoria.codCategoria);
                    string mens = (string)cmd.ExecuteScalar();
                    if (!String.IsNullOrWhiteSpace(mens))
                    {
                        return $"Ya existe la categoria";
                    }

                    string insert = "Insert INTO categoria(NombreCategoria) values (@NombreCategoria)";//No añadimos el codigo por ser autoincrement
                    cmd.CommandText = insert;
                    cmd.Parameters.AddWithValue("@NombreCategoria", categoria.nombreCategoria);
                                        
                    int numFilas = cmd.ExecuteNonQuery();

                    if (numFilas == 0)
                    {
                        return "No has añadido ningún dato";
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }
        /// <summary>
        /// Funcion que permite modificar el nombre de la categoria pasada por parametro
        /// </summary>
        /// <param name="subcategoria"></param>
        /// <returns>Retorna un mensaje ("" si todo ha ido bien)</returns>
        public String ModificarCategoria(Categoria categoria)
        {
            try
            {
                using (var con = GetInstance())
                {
                    var query = "UPDATE categoria Set NombreCategoria = @NombreCategoria WHERE CodigoCategoria = @CodigoCategoria";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@NombreCategoria", categoria.nombreCategoria);
                    cmd.Parameters.AddWithValue("@CodigoCategoria", categoria.codCategoria);

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
        /// <summary>
        /// Metodo que elimina una categoria
        /// </summary>
        /// <param name="deleteCategoria"></param>
        /// <returns>Retorina un mensaje con "" si todo ha ido bien</returns>
        public string EliminarCategoria(Categoria deleteCategoria) // TODO No se puede borrar una categoría y dejar sus productos
        {
            try
            {
                using (var con = GetInstance())
                {
                    var query = "DELETE FROM categoria  WHERE CodigoCategoria = @cod";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@cod", deleteCategoria.codCategoria);
                    string msg = (string)cmd.ExecuteScalar();

                    if (String.IsNullOrWhiteSpace(msg))
                    {
                        return $"La categoria que intentas eliminar no existe";
                    }

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
        /// <summary>
        /// Funcion que permite añadir una categoría
        /// </summary>
        /// <param name="categoria">Categoria que se desea añadir</param>
        /// <returns>Retorna "" si todo ha ido bien, o un mensaje de error en su defecto</returns>
        public string AñadirSubCategoria(Subcategoria subcategoria)
        {
           
            try
            {
                using (var con = GetInstance())
                {

                    var query = "SELECT * FROM subcategoria where CodigoSubCategoria = @cod";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@cod", subcategoria.codSubCategoria);
                    string mens = (string)cmd.ExecuteScalar();
                    if (!String.IsNullOrWhiteSpace(mens))
                    {
                        return $"Ya existe la SubCategoria";
                    }

                    string insert = "Insert INTO subcategoria(NombreSubCategoria) values (@NombreSubCategoria)";//No añadimos el codigo por ser autoincrement
                    cmd.CommandText = insert;
                    cmd.Parameters.AddWithValue("@NombreSubCategoria", subcategoria.nombreSubCategoria);

                    int numFilas = cmd.ExecuteNonQuery();

                    if (numFilas == 0)
                    {
                        return "No has añadido ningún dato";
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }
        /// <summary>
        /// Funcion que permite modificar el nombre de la SubCategoria pasada por parametro
        /// </summary>
        /// <param name="subcategoria"></param>
        /// <returns>Retorna un mensaje ("" si todo ha ido bien)</returns>
        public String ModificarSubCategoria(Subcategoria subcategoria)
        {
            try
            {
                using (var con = GetInstance())
                {
                    var query = "UPDATE subcategoria Set NombreSubCategoria = @NombreSubCategoria WHERE CodigoSubCategoria = @CodigoSubCategoria";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@NombreSubCategoria", subcategoria.nombreSubCategoria);
                    cmd.Parameters.AddWithValue("@CodigoSubCategoria", subcategoria.codSubCategoria);

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
        /// <summary>
        /// Metodo que permite borrar de la base de datos la subcategoria pasada por parametro
        /// </summary>
        /// <param name="deleteSubCategoria"></param>
        /// <returns>Retorna "" si todo ha ido bien o un mensaje de error</returns>
        public string EliminarSubCategoria(Subcategoria deleteSubCategoria)
        {
            try
            {
                using (var con = GetInstance())
                {
                    var query = "DELETE FROM subcategoria WHERE CodigoSubCategoria = @cod";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@cod", deleteSubCategoria.codSubCategoria);
                    string msg = (string)cmd.ExecuteScalar();

                    if (String.IsNullOrWhiteSpace(msg))
                    {
                        return $"La SubCategoria que intentas eliminar no existe";
                    }

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

        #region Funciones para los productos
        /// <summary>
        /// Funcion que Carga los Productos
        /// </summary>
        /// <param name="msg">Mensaje que retorna "" si todo ha ido bien, o un error en su defecto</param>
        /// <returns>Retorna una lista con los Productos, o null en su defecto</returns>
        public List<Producto> CargarProductos(out string msg)
        {
            List<Producto> productos = new List<Producto>();

            try
            {
                using (var con = GetInstance())
                {

                    string query = "SELECT CodigoProducto, Descripcion, Precio, Stock, Categoria.NombreCategoria, SubCategoria.NombreSubCategoria FROM (( productos INNER JOIN subCategoria on productos.CodigoSubCategoria=SubCategoria.CodigoSubcategoria) INNER JOIN categoria on productos.CodigoCategoria=categoria.CodigoCategoria);";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    SQLiteDataReader lector = cmd.ExecuteReader();
                    
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
                            producto.nombreCategoria = lector["NombreCategoria"].ToString();
                            producto.nombreSubCategoria = lector["NombreSubCategoria"].ToString();
                            producto.descripcion = lector["Descripcion"].ToString();
                            producto.precio = int.Parse(lector["Precio"].ToString());
                            producto.stock = int.Parse(lector["Stock"].ToString());

                            productos.Add(producto);
                        }
                    
                    con.Close();
                    lector.Close();
                    msg = "";
                    return productos;
                }
            }
            catch (Exception e)
            {
                msg = e.Message;
                return productos;
            }

        }
        /// <summary>
        /// Funcion que añade un producto nuevo a la base de datos.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Retorna un mensaje con "" si todo ha ido bien, de lo contrario nos retorna un mensaje con el error.</returns>
        public string AnadirProducto(Producto newProducto)
        {

            try
            {
                using (var con = GetInstance())
                {
                    var query = "SELECT * FROM productos WHERE CodigoProducto = @pod";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@pod", newProducto.codigoProducto);
                    string msg = (string)cmd.ExecuteScalar();
                    if (!String.IsNullOrWhiteSpace(msg))
                    {
                        return $"Ya existe el Producto que intentas añadir";
                    }

                    string insert = "INSERT INTO productos(CodigoCategoria,CodigoSubCategoria,Descripcion,Stock,Precio) values (@CodigoCategoria, @CodigoSubCategoria, @Descripcion, @Stock, @Precio)";
                    cmd.CommandText = insert;
                    cmd.Parameters.AddWithValue("@CodigoCategoria", newProducto.codigoCategoria);
                    cmd.Parameters.AddWithValue("@CodigoSubCategoria", newProducto.codigoSubcategoria);
                    cmd.Parameters.AddWithValue("@Descripcion", newProducto.descripcion);
                    cmd.Parameters.AddWithValue("@Stock", newProducto.stock);
                    cmd.Parameters.AddWithValue("@Precio", newProducto.precio);

                    int numFilas = cmd.ExecuteNonQuery();

                    if (numFilas == 0)
                    {
                        return "No has añadido ningun producto";
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                return e.Message;

            }
            return "";
        }
        /// <summary>
        /// Función que modifica la descripcionn stock y precio de un producto.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Retorna un mensaje con "" si todo ha ido bien, de lo contrario nos retorna un mensaje con el error.</returns>
        public String ModificarProducto(Producto producto)
        {
            try
            {
                using (var con = GetInstance())
                {
                    var query = "UPDATE productos Set Descripcion = @Descripcion, Stock = @Stock, Precio = @Precio WHERE CodigoProducto = @CodigoProducto";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@Descripcion", producto.descripcion);
                    cmd.Parameters.AddWithValue("@Stock", producto.stock);
                    cmd.Parameters.AddWithValue("@Precio", producto.precio);

                    cmd.Parameters.AddWithValue("@CodigoProducto", producto.codigoProducto);

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
        /// <summary>
        /// Funcion que elimina el producto elegido.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>Retorna un mensaje con "" si todo ha ido bien, de lo contrario nos retorna un mensaje con el error.</returns>
        public string EliminarProducto(Producto deleteProducto)
        {
            try
            {
                using (var con = GetInstance())
                {
                    var query = "DELETE FROM productos WHERE CodigoProducto = @pod";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@pod", deleteProducto.codigoProducto);
                    string msg = (string)cmd.ExecuteScalar();

                    if (String.IsNullOrWhiteSpace(msg))
                    {
                        return $"El producto que intentas eliminar no existe";
                    }

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

        public List<Producto> BuscarProductosPorDescripcion(String descripcion, out string msg)
        {
            msg = "";
            List<Producto> productos = new List<Producto>();
            try
            {
                using (var con = GetInstance())
                {

                    var query = "SELECT CodigoProducto, Descripcion, Precio, Stock, Categoria.NombreCategoria, SubCategoria.NombreSubCategoria FROM (( productos INNER JOIN subCategoria on productos.CodigoSubCategoria=SubCategoria.CodigoSubcategoria) INNER JOIN categoria on productos.CodigoCategoria=categoria.CodigoCategoria) where Descripcion LIKE @DescripcionLike;";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    cmd.Parameters.AddWithValue("@DescripcionLike", "%"+descripcion+"%");
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
                            producto.nombreCategoria = lector["NombreCategoria"].ToString();
                            producto.nombreSubCategoria = lector["NombreSubCategoria"].ToString();
                            producto.descripcion = lector["Descripcion"].ToString();
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
        #endregion

        #region Funciones para la empresa
        /// <summary>
        /// Funcion que devuelve la empresa de la base de datos
        /// </summary>
        /// <param name="msg"></param>
        /// <returns>Retorna un String con "" o un mensaje de error en su defecto</returns>
        public Empresa CargarEmpresa(out string msg)
        {
            msg = "";
            Empresa empresa = new Empresa();
            try
            {
                using (var con = GetInstance())
                {

                    var query = "SELECT * FROM Empresa";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);
                    using (SQLiteDataReader dradmin = cmd.ExecuteReader())
                    {
                        if (dradmin.Read()) // ES UN IF, PORQUE SOLO ES UN CAMPO
                        {
                            empresa.nombre = dradmin["Nombre"].ToString();
                            empresa.logo = dradmin["Logo"].ToString();
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception e)
            {
                msg = e.Message;

            }
            return empresa;
        }
        /// <summary>
        /// Funcion que permite modificar el nombre y el logo de una empresa
        /// </summary>
        /// <param name="empresa"></param>
        /// <returns>Retorna un String con "" si todo ha ido bien o un mensaje de error en su defecto</returns>
        public String ModificarEmpresa(Empresa empresa)
        {
            try
            {
                using (var con = GetInstance())
                {
                    var query = "UPDATE Empresa Set Nombre = @Nombre, Logo = @Logo WHERE Nombre = @Nombre";
                    SQLiteCommand cmd = new SQLiteCommand(query, con);

                    cmd.Parameters.AddWithValue("@Nombre", empresa.nombre);
                    cmd.Parameters.AddWithValue("@Logo", empresa.logo);

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

    }

}
