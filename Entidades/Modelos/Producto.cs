using Entidades.BaseDeDatos;
using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Producto
    {
        private string nombreDelProducto;
        private string categoriaDelProducto;
        private float precioDelProducto;
        private int stockDelProducto;

        public Producto(string nombreDelProducto, string categoriaDelProducto, string precioDelProducto, string stockDelProducto)
        {
            this.nombreDelProducto = ValidacionNombreDelProducto(nombreDelProducto);
            this.categoriaDelProducto = ValidacionCategoriaDelProducto(categoriaDelProducto);
            this.precioDelProducto = ValidacionPrecioDelProducto(precioDelProducto);
            this.stockDelProducto = ValidacionStockDelProducto(stockDelProducto);
        }
        #region "Propiedades"
        public string NombreDelProducto { get { return  nombreDelProducto; } }
        public string CategoriaDelProducto { get { return categoriaDelProducto; } }
        public float PrecioDelProducto { get { return precioDelProducto; } }
        public int StockDelProducto { get { return stockDelProducto; } }
        #endregion

        #region "Validaciones"
        /// <summary>
        /// Método encargado de validar que el nombre del producto ingresado no esté contenido 
        /// de espacios en blanco ni sea nulo, que su longitud no sea mayor a 50 carácteres 
        /// y que no tenga caracteres invalidos.
        /// </summary>
        /// <param name="nombreDelProducto">Nombre del producto a validar.</param>
        /// <returns>
        /// Nombre del producto validado.
        /// </returns>
        /// <exception cref="NombreProductoInvalidoException"></exception>
        private string ValidacionNombreDelProducto(string nombreDelProducto)
        {
            int contadorDeLetras = 0;
            if (!string.IsNullOrWhiteSpace(nombreDelProducto))
            {
                if (nombreDelProducto.Length > 50)
                {
                    throw new NombreProductoInvalidoException("Error. El nombre del producto ingresado es muy largo.");
                }
                foreach (char c in nombreDelProducto)
                {
                    if (char.IsLetter(c))
                    {
                        contadorDeLetras++;
                    }
                }
                if (contadorDeLetras == 0)
                {
                    throw new NombreProductoInvalidoException("Error. El nombre del producto debe contener al menos una letra.");
                }
                return nombreDelProducto;
            }
            else
            {
                throw new NombreProductoInvalidoException("Error. Ingrese un nombre para su producto.");
            }
        }
        /// <summary>
        /// Método encargado de validar que la categoría del producto ingresado no sea nula ni esté vacía.
        /// </summary>
        /// <param name="categoriaDelProducto">Categoría del producto a validar.</param>
        /// <returns>
        /// Nombre de la categoría del producto validada.
        /// </returns>
        /// <exception cref="CategoriaDeProductoInvalidaException"></exception>
        private string ValidacionCategoriaDelProducto(string categoriaDelProducto)
        {
            if (string.IsNullOrEmpty(categoriaDelProducto))
            {
                throw new CategoriaDeProductoInvalidaException("Error. Ingrese una categoría para su producto.");
            }
            return categoriaDelProducto;
        }
        /// <summary>
        /// Método encargado de validar que el precio del producto ingresado no sea nulo ni este vacio,
        /// que el precio no sea menor ni igual a 0, y que sea parseable a un flotante.
        /// </summary>
        /// <param name="precioDelProducto">Precio del producto a validar.</param>
        /// <returns>
        /// Precio del producto validado.
        /// </returns>
        /// <exception cref="PrecioDelProductoInvalidoException"></exception>
        private float ValidacionPrecioDelProducto(string precioDelProducto)
        {
            try
            {
                float precioDelProductoParseado;

                if (string.IsNullOrEmpty(precioDelProducto) || string.IsNullOrWhiteSpace(precioDelProducto))
                {
                    throw new PrecioDelProductoInvalidoException("Error. Ingrese un precio para su producto.");
                }
                else
                {
                    precioDelProductoParseado = float.Parse(precioDelProducto);
                }

                if (precioDelProductoParseado <= 0)
                {
                    throw new PrecioDelProductoInvalidoException("Error. Ingrese un precio que sea mayor a 0.");
                }

                return precioDelProductoParseado;
            }
            catch (FormatException)
            {
                throw new PrecioDelProductoInvalidoException("Error en el ingreso del precio. Debe contener solo números.");
            }
        }
        /// <summary>
        /// Método encargado de validar que el stock ingresado del producto no sea una cadena nula ni vacía,
        /// que sea parseable a entero y que no sea menor a 0.
        /// </summary>
        /// <param name="stockDelProducto">Stock del producto a validar.</param>
        /// <returns>
        /// Stock del producto validado.
        /// </returns>
        /// <exception cref="StockProductoInvalidoException"></exception>
        private int ValidacionStockDelProducto(string stockDelProducto)
        {
            try
            {
                int stockDelProductoParseado;
                if (string.IsNullOrEmpty(stockDelProducto) || string.IsNullOrWhiteSpace(stockDelProducto))
                {
                    throw new StockProductoInvalidoException("Error. Ingrese el stock para su producto.");
                }
                else
                {
                    stockDelProductoParseado = int.Parse(stockDelProducto);
                }

                if (stockDelProductoParseado < 0)
                {
                    throw new StockProductoInvalidoException("Error, debe ingresar un stock mayor o igual a 0.");
                }
                return stockDelProductoParseado;
            }
            catch (FormatException)
            {
                throw new StockProductoInvalidoException("Error en el ingreso del stock. Debe contener solo números.");
            }
        }
        #endregion
    }
}
