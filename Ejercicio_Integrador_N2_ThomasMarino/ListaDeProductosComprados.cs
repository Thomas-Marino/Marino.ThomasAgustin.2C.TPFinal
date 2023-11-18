using Ejercicio_Integrador_N2_ThomasMarino.Properties;
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
    public partial class ListaDeProductosComprados : UserControl
    {
        private string _nombreDelProducto;
        private string _precioTotalPagado;
        private string _precioUnitarioDelProducto;
        private string _cantidadCompradaDelProducto;
        private string _publicadorDelProducto;
        private string _imagenCategoriaProducto;
        private string categoriaDelProducto;
        private string _fechaDeCompra;
        private string idProducto;


        public ListaDeProductosComprados()
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
            set { _fechaDeCompra = value; LblFechaDeCompra.Text = FormatearString("Fecha de compra: ", value); }
        }

        [Category("Propiedades Añadidas")]
        public string ImagenCategoriaProducto
        {
            get { return _imagenCategoriaProducto; }
            set { _imagenCategoriaProducto = value; PbImagenProductoDeseado.Image = AsignadorDeImagenes(value); }
        }
        [Category("Propiedades Añadidas")]
        public string NombreDelProducto
        {
            get { return _nombreDelProducto; }
            set { _nombreDelProducto = value; LblNombreProductoAñadido.Text = value; }
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
        public string CantidadCompradaDelProducto
        {
            get { return _cantidadCompradaDelProducto; }
            set { _cantidadCompradaDelProducto = value; LblCantidadProductoDeseada.Text = FormatearString("Cantidad comprada:", value); }
        }
        [Category("Propiedades Añadidas")]
        public string PublicadorDelProducto
        {
            get { return _publicadorDelProducto; }
            set { _publicadorDelProducto = value; LblPublicadorProducto.Text = FormatearString("Publicador:", value); }
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
        private static Image AsignadorDeImagenes(string categoria)
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
        private static string FormatearString(string mensaje, string valor)
        {
            return $"{mensaje} {valor}";
        }
        #endregion
    }
}
