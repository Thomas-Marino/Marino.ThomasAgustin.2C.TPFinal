using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class GestorSql
    {
        private static string stringConnection;

        static GestorSql()
        {
            GestorSql.stringConnection = "Server=.;Database=DeliveredDB;Trusted_Connection=True;";
        }

        public static bool LoggearUsuario(string usuario)
        {
            SqlConnection connection = new SqlConnection(GestorSql.stringConnection);

            string sentencia = $"SELECT usuario FROM PERSONAS WHERE usuario='{usuario}'";
            try
            {
                SqlCommand command = new SqlCommand(sentencia, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (connection != null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
