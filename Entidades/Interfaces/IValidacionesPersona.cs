using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entidades.Interfaces
{
    public interface IValidacionesPersona
    {
        string ValidacionNombre(string nombre);
        string ValidacionApellido(string apellido);
        int ValidacionDni(string dni);
    }
}
