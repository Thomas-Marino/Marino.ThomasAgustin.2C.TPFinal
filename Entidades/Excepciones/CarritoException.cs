using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class CarritoException : Exception
    {
        public CarritoException(string? message) : base(message)
        {
        }

        public CarritoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
