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

        public static bool CrearNuevaCuenta(Usuario usuario)
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
    }
}