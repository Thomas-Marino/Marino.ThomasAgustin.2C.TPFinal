using Ejercicio_Integrador_N2_ThomasMarino;
using Ejercicio_Integrador_N2_ThomasMarino.Properties;
using Entidades.Archivos;
using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_Integrador_N2_ThomasMarino
{
    public partial class ListaDeProductosEnCarrito : UserControl
    {
        public ListaDeProductosEnCarrito()
        {
            InitializeComponent();
        }

        private string _nombreDelProducto;
        private string _precioTotalDelProducto;
        private string _precioUnitarioDelProducto;
        private string _cantidadDeseadaDelProducto;
        private string _publicadorDelProducto;
        private string _imagenCategoriaProducto;
        private string categoriaDelProducto;
        private string idProducto;

        private void BtnEliminarDelCarrito_Click(object sender, EventArgs e)
        {
            SerializadorArchivos<List<Dictionary<string, object>>> serializadorArchivos = new SerializadorArchivos<List<Dictionary<string, object>>>();
            List<Dictionary<string, object>> datos = new List<Dictionary<string, object>>();
            FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
            FormCarrito formCarrito = Application.OpenForms.OfType<FormCarrito>().FirstOrDefault();

            string compradorDelProducto = formIngreso.usuarioLoggeado;
            string ruta = $"..\\..\\..\\..\\Carrito\\Carrito{compradorDelProducto}.json";
            datos = serializadorArchivos.Deserializar(ruta);  // Deserializo el contenido existente

            List<Dictionary<string, object>> copiaDatos = new List<Dictionary<string, object>>(datos);

            foreach (var producto in copiaDatos) // Elimino el producto deseado
            {
                if (producto["ID"].ToString() == IdProducto.ToString())
                {
                    datos.Remove(producto);
                }
            }

            serializadorArchivos.Serializar(datos, ruta); // Vuelvo a serializar los datos en el archivo.
            formCarrito.MostrarProductos();
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
        public string PrecioTotalDelProducto
        {
            get { return _precioTotalDelProducto; }
            set { _precioTotalDelProducto = value; LblPrecioTotalProducto.Text = FormatearString("Precio total: $", value); }
        }
        [Category("Propiedades Añadidas")]
        public string PrecioUnitarioDelProducto
        {
            get { return _precioUnitarioDelProducto; }
            set { _precioUnitarioDelProducto = value; LblPrecioUnitarioProducto.Text = FormatearString("Precio por unidad: $", value); }
        }

        [Category("Propiedades Añadidas")]
        public string CantidadDeseadaDelProducto
        {
            get { return _cantidadDeseadaDelProducto; }
            set { _cantidadDeseadaDelProducto = value; LblCantidadProductoDeseada.Text = FormatearString("Cantidad deseada:", value); }
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
