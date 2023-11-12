using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class StockProductoInvalidoException : Exception
    {
        public StockProductoInvalidoException(string? message) : base(message)
        {
        }

        public StockProductoInvalidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
