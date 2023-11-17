using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    internal interface IValidacionesUsuario
    {
        string ValidacionContraseña(string contraseña);
        string ValidacionUsuario(string usuario);
    }
}
