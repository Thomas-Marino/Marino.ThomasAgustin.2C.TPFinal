using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CategoriaDeProductoInvalidaException : Exception
    {
        public CategoriaDeProductoInvalidaException(string? message) : base(message)
        {
        }

        public CategoriaDeProductoInvalidaException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
