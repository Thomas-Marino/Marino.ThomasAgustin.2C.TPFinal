using Entidades.Excepciones;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.BaseDeDatos
{
    public static class GestorPersonasSqlDelivered
    {
        private static string stringConnection;

        static GestorPersonasSqlDelivered()
        {
            stringConnection = "Server=.;Database=DeliveredDB;Trusted_Connection=True;";
        }

        #region "Verificaciones datos"
        /// <summary>
        /// Método encargado de verificar la existencia de un usuario en la base de datos.
        /// </summary>
        /// <param name="usuario">Nombre de usuario a verificar</param>
        /// <returns>
        /// True si el usuario está presente en la base de datos.
        /// False en caso contrario.
        /// </returns>
        public static bool VerificarExistenciaUsuario(string usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorPersonasSqlDelivered.stringConnection))
                {
                    string query = "SELECT usuario FROM personas WHERE usuario=@usuario";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("usuario", usuario);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// Método encargado de verificar la existencia del dni de un usuario registrado en la base de datos.
        /// </summary>
        /// <param name="dni">Dni a ser buscado</param>
        /// <returns>
        /// True si se encuentra el dni dentro de la base de datos.
        /// False caso contrario.
        /// </returns>
        public static bool VerificarExistenciaDni(int dni)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorPersonasSqlDelivered.stringConnection))
                {
                    string query = "SELECT dni FROM personas WHERE dni=@dni";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("dni", dni);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion

        #region "Importación/Exportación de información"
        /// <summary>
        /// Método que cumple con el propósito de realizar la autenticación de un usuario,
        /// comparando las credenciales proporcionadas con la base de datos.
        /// </summary>
        /// <param name="usuario">Nombre de usuario para la autenticación.</param>
        /// <param name="contraseña">Contraseña asociada al usuario para la autenticación.</param>
        /// <returns>
        ///  True si las credenciales son válidas y se encuentra el usuario en la base de datos.
        ///  False si las credenciales son inválidas o el usuario no existe en la base de datos.
        /// </returns>
        public static bool LoggearCuenta(string usuario, string contraseña) 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorPersonasSqlDelivered.stringConnection))
                {
                    string query = "SELECT usuario, contraseña FROM personas WHERE usuario=@usuario COLLATE Latin1_General_BIN AND contraseña=@contraseña COLLATE Latin1_General_BIN";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("usuario", usuario);
                    command.Parameters.AddWithValue("contraseña", contraseña);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        /// <summary>
        /// Método encargado de realizar una busqueda de un nombre de usuario dentro de la base
        /// de datos.
        /// </summary>
        /// <param name="usuario">Nombre de usuario a buscar</param>
        /// <returns>
        /// Si el nombre de usuario está presente en la base de datos, será retornado como string.
        /// Caso contrario, retornará un string informando que no ha sido encontrado.
        /// </returns>
        public static string ObtenerNombreDelUsuario(string usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorPersonasSqlDelivered.stringConnection))
                {
                    string query = "SELECT nombre FROM personas WHERE usuario=@usuario";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("usuario", usuario);

                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return reader.GetString(0);
                    }
                    return "No se encontro ningun nombre asociado a ese usuario.";
                }
            }
            catch (Exception ex)
            {
                return $"Hubo un error al obtener el nombre del usuario. {ex}";
            }
        }
        /// <summary>
        /// Método encargado de añadir un nuevo usuario a la base de datos.
        /// </summary>
        /// <param name="usuario">usuario a añadir.</param>
        /// <returns>
        /// True si el usuario pudo añadirse con éxito a la base de datos.
        /// </returns>
        /// <exception cref="BaseDeDatosException"></exception>
        public static bool AñadirUsuario(Usuario usuario)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GestorPersonasSqlDelivered.stringConnection))
                {
                    string query = "INSERT INTO personas (dni,nombre,apellido,usuario,contraseña)" +
                        "values (@dni,@nombre,@apellido,@usuario,@contraseña)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("dni", usuario.Dni);
                    command.Parameters.AddWithValue("nombre", usuario.Nombre);
                    command.Parameters.AddWithValue("apellido", usuario.Apellido);
                    command.Parameters.AddWithValue("usuario", usuario.NombreUsuario);
                    command.Parameters.AddWithValue("contraseña", usuario.Contraseña);

                    connection.Open();
                    command.ExecuteNonQuery();

                    return true;
                }
            }
            catch(Exception ex)
            {
                throw new BaseDeDatosException("Error al añadir un usuario a la base de datos.", ex);
            }
        }
        #endregion
    }
}