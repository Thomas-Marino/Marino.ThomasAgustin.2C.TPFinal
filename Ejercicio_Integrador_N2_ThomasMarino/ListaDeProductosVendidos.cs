using Ejercicio_Integrador_N2_ThomasMarino.Properties;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Integrador_N2_ThomasMarino
{
    public partial class ListaDeProductosVendidos : UserControl
    {
        private string _nombreDelProductoVendido;
        private string _precioTotalPagado;
        private string _precioUnitarioDelProducto;
        private string _cantidadVendidaDelProducto;
        private string _compradorDelProducto;
        private string _imagenCategoriaProducto;
        private string categoriaDelProducto;
        private string _fechaDeCompra;
        private string idProducto;

        public ListaDeProductosVendidos()
        {
            InitializeComponent();
        }

        #region "Propiedades"
        public string IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        public string CategoriaDelProducto
        {
            get { return categoriaDelProducto; }
            set { categoriaDelProducto = value; }
        }

        public string FechaDeCompra
        {
            get { return _fechaDeCompra; }
            set { _fechaDeCompra = value; LblFechaDeVenta.Text = FormatearString("Fecha de venta: ", value); }
        }

        [Category("Propiedades Añadidas")]
        public string ImagenCategoriaProducto
        {
            get { return _imagenCategoriaProducto; }
            set { _imagenCategoriaProducto = value; PbImagenProductoDeseado.Image = AsignadorDeImagenes(value); }
        }
        [Category("Propiedades Añadidas")]
        public string NombreDelProductoVendido
        {
            get { return _nombreDelProductoVendido; }
            set { _nombreDelProductoVendido = value; LblNombreProductoVendido.Text = value; }
        }
        [Category("Propiedades Añadidas")]
        public string PrecioTotalPagado
        {
            get { return _precioTotalPagado; }
            set { _precioTotalPagado = value; LblPrecioTotalProducto.Text = FormatearString("Precio pagado: $", value); }
        }
        [Category("Propiedades Añadidas")]
        public string PrecioUnitarioDelProducto
        {
            get { return _precioUnitarioDelProducto; }
            set { _precioUnitarioDelProducto = value; LblPrecioUnitarioProducto.Text = FormatearString("Precio por unidad: $", value); }
        }

        [Category("Propiedades Añadidas")]
        public string CantidadVendidaDelProducto
        {
            get { return _cantidadVendidaDelProducto; }
            set { _cantidadVendidaDelProducto = value; LblCantidadProductoVendido.Text = FormatearString("Cantidad comprada:", value); }
        }
        [Category("Propiedades Añadidas")]
        public string CompradorDelProducto
        {
            get { return _compradorDelProducto; }
            set { _compradorDelProducto = value; LblCompradorProducto.Text = FormatearString("Comprador:", value); }
        }
        #endregion

        #region "Metodos"
        /// <summary>
        /// Método encargado de asignarle una imagen al producto publicado
        /// dependiendo de la categoría seleccionada.
        /// </summary>
        /// <param name="categoria">Categoria ingresada.</param>
        /// <returns>
        /// Imagen de la categoria ingresada.
        /// </returns>
        private Image AsignadorDeImagenes(string categoria)
        {
            switch (categoria)
            {
                case "Vehiculos":
                    return Resources.ImgVehiculos;
                case "Muebles":
                    return Resources.ImgMuebles;
                case "Herramientas":
                    return Resources.ImgHerramientas;
                case "Tecnología":
                    return Resources.ImgTecnología;
                default:
                    return Resources.ImgError;
            }
        }
        /// <summary>
        /// Método encargado de darle un formato a los strings deseados.
        /// </summary>
        /// <param name="mensaje">Mensaje a incluir en el string.</param>
        /// <param name="valor">Valor de la propiedad a mostrar.</param>
        /// <returns>
        /// String formateado.
        /// </returns>
        private string FormatearString(string mensaje, string valor)
        {
            return $"{mensaje} {valor}";
        }
        #endregion
    }
}
