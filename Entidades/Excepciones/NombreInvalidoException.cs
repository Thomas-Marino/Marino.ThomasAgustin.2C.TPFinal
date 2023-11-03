using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class NombreinvalidoException : Exception
    {
        public NombreinvalidoException(string? message) : base(message)
        {
        }

        public NombreinvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
