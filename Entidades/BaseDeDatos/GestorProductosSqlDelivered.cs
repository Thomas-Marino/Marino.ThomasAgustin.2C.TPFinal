using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades.Excepciones;
using Entidades.Modelos;
using Entidades.MetodosDeExtension;

namespace Entidades.BaseDeDatos
{
    public class GestorProductosSqlDelivered
    {
        private static string stringConnection;

        static GestorProductosSqlDelivered()
        {
            stringConnection = "Server=.;Database=DeliveredDB;Trusted_Connection=True;";
        }

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
        public static void RestarStockProducto(int cantidad, int id_producto)
        {

        }
        public static void SumarStockProducto(int cantidad, int id_producto)
        {

        }
    }
}
