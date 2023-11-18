using Ejercicio_Integrador_N2_ThomasMarino.Properties;
using Entidades.Archivos;
using Entidades.Excepciones;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Integrador_N2_ThomasMarino
{
    public partial class ListaDeProductos : UserControl
    {
        private string _nombreDelProducto;
        private string _precioDelProducto;
        private string _stockDelProducto;
        private string _publicadorDelProducto;
        private string _imagenCategoriaProducto;
        private string categoriaDelProducto;
        private string idProducto;

        public ListaDeProductos()
        {
            InitializeComponent();
        }

        private void BtnAñadirAlCarrito_Click(object sender, EventArgs e)
        {
            try
            {
                SerializadorArchivos<List<Dictionary<string, object>>> serializadorArchivos = new SerializadorArchivos<List<Dictionary<string, object>>>();
                List<Dictionary<string, object>> datos = new List<Dictionary<string, object>>();
                FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();

                string compradorDelProducto = formIngreso.usuarioLoggeado;
                string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
                string ruta = $"..\\..\\..\\..\\Carrito\\Carrito{compradorDelProducto}.json";

                if (File.Exists(ruta)) // Verifico si el archivo carrito ya existe para cierto usuario
                {
                    datos = serializadorArchivos.Deserializar(ruta);  // Deserializo el contenido existente

                    Dictionary<string, object> dictDatos = new Dictionary<string, object>() // Añado nuevo producto
                    {
                        { "ID", IdProducto },
                        { "nombre", NombreDelProducto },
                        { "categoria", CategoriaDelProducto },
                        { "precio unitario", float.Parse(PrecioDelProducto) },
                        { "cantidad", NUDCantidadProductoDeseada.Value },
                        { "precio total", float.Parse(PrecioDelProducto) * Convert.ToInt32(NUDCantidadProductoDeseada.Value) },
                        { "publicador", PublicadorDelProducto },
                        { "comprador", compradorDelProducto }
                    };

                    foreach (var producto in datos) // Verifico que no se añadan dos veces los mismos productos al carrito
                    {
                        if (producto["ID"].ToString() == dictDatos["ID"].ToString())
                        {
                            throw new CarritoException("Error. Ya añadió ese producto al carrito.");
                        }
                    }
                    datos.Add(dictDatos);
                }
                else
                {
                    datos = new List<Dictionary<string, object>>() // Creo un nuevo archivo con el primer producto en el caso de que no haya otro archivo ya creado
                    {
                        new Dictionary<string, object>()
                        {
                            { "ID", IdProducto },
                            { "nombre", NombreDelProducto },
                            { "categoria", CategoriaDelProducto },
                            { "precio unitario", float.Parse(PrecioDelProducto) },
                            { "cantidad", NUDCantidadProductoDeseada.Value },
                            { "precio total", float.Parse(PrecioDelProducto) * Convert.ToInt32(NUDCantidadProductoDeseada.Value) },
                            { "publicador", PublicadorDelProducto },
                            { "comprador", compradorDelProducto }
                        }
                    };
                }

                serializadorArchivos.Serializar(datos, ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            set { PbImagenProducto.Image = AsignadorDeImagenes(value); }
        }
        [Category("Propiedades Añadidas")]
        public string NombreDelProducto
        {
            get { return _nombreDelProducto; }
            set { _nombreDelProducto = value; LblNombreProducto.Text = value; }
        }
        [Category("Propiedades Añadidas")]
        public string PrecioDelProducto
        {
            get { return _precioDelProducto; }
            set { _precioDelProducto = value; LblPrecioProducto.Text = FormatearString("Precio: $", value); }
        }
        [Category("Propiedades Añadidas")]
        public string StockDelProducto
        {
            get { return _stockDelProducto; }
            set { _stockDelProducto = value; LblStockProducto.Text = FormatearString("Stock disponible:", value); }
        }
        [Category("Propiedades Añadidas")]
        public string PublicadorDelProducto
        {
            get { return _publicadorDelProducto; }
            set { _publicadorDelProducto = value; LblPublicadorProducto.Text = FormatearString("Publicador:", value); }
        }

        #endregion

        #region "métodos"
        /// <summary>
        /// Método encargado de limitar la cantidad maxima y minima de compra dependiendo
        /// del stock del producto.
        /// </summary>
        /// <param name="limite">Limite máximo de la compra</param>
        public void AsignarLimiteDeCompra(decimal limite)
        {
            this.NUDCantidadProductoDeseada.Maximum = limite;
            this.NUDCantidadProductoDeseada.Minimum = 1;
        }
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
