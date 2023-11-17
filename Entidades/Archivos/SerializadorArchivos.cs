using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class SerializadorArchivos<T>
    {
        public void Serializar(T datos, string rutaArchivo)
        {
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions();
                options.WriteIndented = true;

                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    string datosJson = JsonSerializer.Serialize(datos, options);
                    sw.Write(datosJson);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al serializar: {ex.Message}");
            }
        }

        public T Deserializar(string rutaArchivo)
        {
            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string jsonString = sr.ReadToEnd();
                    var datos = JsonSerializer.Deserialize<T>(jsonString);
                    return datos;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("", ex);
            }
        }
    }


}
