using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class PrecioDelProductoInvalidoException : Exception
    {
        public PrecioDelProductoInvalidoException(string? message) : base(message)
        {
        }

        public PrecioDelProductoInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
