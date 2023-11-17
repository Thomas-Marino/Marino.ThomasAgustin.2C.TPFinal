using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades.Excepciones;
using Entidades.Modelos;
using Entidades.MetodosDeExtension;
using System.Runtime.Versioning;

namespace Entidades.BaseDeDatos
{
    public class GestorProductosSqlDelivered
    {
        private static string stringConnection;

        static GestorProductosSqlDelivered()
        {
            stringConnection = "Server=.;Database=DeliveredDB;Trusted_Connection=True;";
        }

        #region "Importación/Exportación de datos."
        /// <summary>
        /// Método encargado de añadir un nuevo producto a la base de datos.
        /// </summary>
        /// <param name="producto">producto a añadir</param>
        /// <param name="publicador">Nombre del publicador del producto</param>
        /// <returns>
        /// True si el producto ha sido añadido con éxito.
        /// </returns>
        /// <exception cref="BaseDeDatosException"></exception>
        public static bool CrearNuevoProducto(Producto producto, string publicador)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorProductosSqlDelivered.stringConnection))
                {
                    string query = "INSERT INTO productos (nombre,categoria,precio,stock,publicador)" +
                        "values (@nombre,@categoria,@precio,@stock,@publicador)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("nombre", producto.NombreDelProducto);
                    command.Parameters.AddWithValue("categoria", producto.CategoriaDelProducto);
                    command.Parameters.AddWithValue("precio", producto.PrecioDelProducto);
                    command.Parameters.AddWithValue("stock", producto.StockDelProducto);
                    command.Parameters.AddWithValue("publicador", publicador);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Error al añadir un producto a la base de datos.", ex);
            }
        }
        /// <summary>
        /// Método encargado de importar todos los productos dentro de la base de datos.
        /// </summary>
        /// <returns>
        /// Lista de diccionarios con todos los productos de la base de datos.
        /// </returns>
        /// <exception cref="BaseDeDatosException"></exception>
        public static List<Dictionary<string, object>> ObtenerTodosLosProductos()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorProductosSqlDelivered.stringConnection))
                {
                    List<Dictionary<string, object>> productos = new List<Dictionary<string, object>>();
                    string query = "SELECT * FROM productos";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> filas = new Dictionary<string, object>();
                            Producto productoObtenido = new Producto(reader.GetString(1), reader.GetString(2), reader.GetDouble(3).ToString(), reader.GetInt32(4).ToString());
                            
                            int idProducto = reader.GetInt32(0);
                            string publicadorProducto = reader.GetString(5);

                            filas.Add("ID", idProducto);
                            filas.Add("nombreDelProducto", productoObtenido.NombreDelProducto);
                            filas.Add("categoriaDelProducto", productoObtenido.CategoriaDelProducto);
                            filas.Add("precioDelProducto", productoObtenido.PrecioDelProducto);
                            filas.Add("stockDelProducto", productoObtenido.StockDelProducto);
                            filas.Add("publicadorDelProducto", publicadorProducto);
                            productos.Add(filas);
                        }
                    }
                    return productos;
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Hubo un error al obtener los productos.", ex);
            }
        }
        /// <summary>
        /// Método encargado de importar los productos de la base de datos, seleccionando solo los
        /// deseados por el usuario mediante el uso de "filtros".
        /// </summary>
        /// <param name="categoria">Categoria de productos a filtrar.</param>
        /// <param name="filtrarPorNombre">Nombre del producto a filtrar.</param>
        /// <param name="filtrarPorPublicador">Nombre del publicador a filtrar.</param>
        /// <param name="orden">"Ascendente" si se desea ordenar los productos por precio ascendente o "Descendente" en caso contrario</param>
        /// <returns>
        /// Lista de diccionarios <string, object> con los productos obtenidos a través de los filtros realizados.
        /// </returns>
        /// <exception cref="BaseDeDatosException"></exception>
        public static List<Dictionary<string, object>> ObtenerProductosFiltrados
            (string categoria, string filtrarPorNombre, string filtrarPorPublicador, string orden)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorProductosSqlDelivered.stringConnection))
                {
                    List<Dictionary<string, object>> productos = new List<Dictionary<string, object>>();
                    SqlCommand command;

                    if (categoria == "VER TODO" && filtrarPorPublicador != null && filtrarPorNombre != null)
                    {
                        string query = "SELECT * FROM productos WHERE categoria IN ('Muebles', 'Vehiculos', 'Tecnología', 'Herramientas') AND nombre LIKE @nombre AND publicador LIKE @publicador";

                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("publicador", "%" + filtrarPorPublicador + "%");
                        command.Parameters.AddWithValue("nombre", "%" + filtrarPorNombre + "%");
                    }
                    else if (categoria != "VER TODO" && filtrarPorPublicador != null && filtrarPorNombre != null)
                    {
                        string query = "SELECT * FROM productos WHERE categoria=@categoria AND nombre LIKE @nombre AND publicador LIKE @publicador";

                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("categoria", categoria);
                        command.Parameters.AddWithValue("publicador", "%" + filtrarPorPublicador + "%");
                        command.Parameters.AddWithValue("nombre", "%" + filtrarPorNombre + "%");
                    }
                    else if (categoria == "VER TODO" && filtrarPorPublicador != null)
                    {
                        string query = "SELECT * FROM productos WHERE categoria IN ('Muebles', 'Vehiculos', 'Tecnología', 'Herramientas') AND publicador LIKE @publicador";

                        command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("publicador", "%" + filtrarPorPublicador + "%");
                    }
                    else if (categoria != "VER TODO" && filtrarPorPublicador != null)
                    {
                        string query = "SELECT * FROM productos WHERE categoria=@categoria AND publicador LIKE @publicador";

                        command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("categoria", categoria);
                        command.Parameters.AddWithValue("publicador", "%" + filtrarPorPublicador + "%");
                    }
                    else if (categoria == "VER TODO" && filtrarPorNombre != null)
                    {
                        string query = "SELECT * FROM productos WHERE categoria IN ('Muebles', 'Vehiculos', 'Tecnología', 'Herramientas') AND nombre LIKE @nombre";

                        command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("nombre", "%" + filtrarPorNombre + "%");
                    }
                    else
                    {
                        string query = "SELECT * FROM productos WHERE categoria=@categoria AND nombre LIKE @nombre";

                        command = new SqlCommand(query, connection);

                        command.Parameters.AddWithValue("categoria", categoria);
                        command.Parameters.AddWithValue("publicador", "%" + filtrarPorNombre + "%");
                    }

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> filas = new Dictionary<string, object>();
                            Producto productoObtenido = new Producto(reader.GetString(1), reader.GetString(2), reader.GetDouble(3).ToString(), reader.GetInt32(4).ToString());
                            
                            string publicadorProducto = reader.GetString(5);
                            int idProducto = reader.GetInt32(0);

                            filas.Add("ID", idProducto);
                            filas.Add("nombreDelProducto", productoObtenido.NombreDelProducto);
                            filas.Add("categoriaDelProducto", productoObtenido.CategoriaDelProducto);
                            filas.Add("precioDelProducto", productoObtenido.PrecioDelProducto);
                            filas.Add("stockDelProducto", productoObtenido.StockDelProducto);
                            filas.Add("publicadorDelProducto", publicadorProducto);
                            productos.Add(filas);
                        }
                        if (orden != null)
                        {
                            productos.BubbleSortPorKey(orden, "precioDelProducto");
                        }
                    }
                    return productos;
                }
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Hubo un error al obtener los productos.", ex);
            }
        }
        #endregion

        #region "Modificacion de datos."
        /// <summary>
        /// Método encargado de restar el stock de un producto dentro de la base de datos
        /// </summary>
        /// <param name="cantidad">Cantidad a restar del stock del producto</param>
        /// <param name="id_producto">Id del producto a modificar</param>
        /// <exception cref="BaseDeDatosException"></exception>
        public static void RestarStockProducto(string cantidad, string id_producto)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorProductosSqlDelivered.stringConnection))
                {
                    SqlCommand command;

                    string query = $"UPDATE productos SET stock=stock-{int.Parse(cantidad)} WHERE id_producto={int.Parse(id_producto)}";

                    command = new SqlCommand(query, connection);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw new BaseDeDatosException("Hubo un error al modificar el stock del producto.", e);
            }
        }
        #endregion
    }
}
