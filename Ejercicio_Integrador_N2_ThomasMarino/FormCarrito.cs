using Entidades.Archivos;
using Entidades.BaseDeDatos;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Integrador_N2_ThomasMarino
{
    public partial class FormCarrito : Form
    {
        public FormCarrito()
        {
            InitializeComponent();
        }

        private void FormCarrito_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            if (FlpProductosDelCarrito.Controls.Count == 0)
            {
                BtnRealizarCompra.Enabled = false;
            }
        }

        private void BtnRealizarCompra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxbDireccionDeEntrega.Text))
            {
                FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
                string compradorDelProducto = formIngreso.usuarioLoggeado;
                string ruta = $"..\\..\\..\\..\\Carrito\\Carrito{compradorDelProducto}.json";
                if (File.Exists(ruta))
                {
                    MessageBox.Show($"Compra realizada con éxito! Su pedido será enviado a: {TxbDireccionDeEntrega.Text}.\nMuchas gracias!", "Compra realizada con éxito!", MessageBoxButtons.OK);

                    SerializadorArchivos<List<Dictionary<string, object>>> serializadorArchivos = new SerializadorArchivos<List<Dictionary<string, object>>>();
                    List<Dictionary<string, object>> datosObtenidos = new List<Dictionary<string, object>>();

                    datosObtenidos = serializadorArchivos.Deserializar(ruta);

                    foreach (var producto in datosObtenidos)// Por cada producto en el carrito, resto el stock comprado.
                    {
                        GestorProductosSqlDelivered.RestarStockProducto($"{producto["cantidad"]}", $"{producto["ID"]}");
                    }
                    GuardarDatosDeVenta();
                    GuardarDatosDeCompra(); // Guardo los datos de la compra
                    File.Delete(ruta); // Elimino el archivo carrito.
                    MostrarProductos(); // Vuelvo a mostrar los productos (En este caso no se mostrará nada ya que el archivo carrito es inexistente.)
                }
                else
                {
                    MessageBox.Show($"Error, no hay productos en su carrito.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Ingrese una direccion de entrega para sus productos porfavor.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #region "Metodos"
        /// <summary>
        /// Método encargado de agregar productos al panel de la interfaz de usuario a partir de datos obtenidos.
        /// </summary>
        /// <param name="datosObtenidos">Lista de diccionarios que contiene los datos de productos.</param>
        /// <param name="listaDeProductosEnCarrito">Lista de productos en carrito (user control)</param>
        private void AgregarProductosAlPanel(List<Dictionary<string, object>> datosObtenidos, ListaDeProductosEnCarrito[] listaDeProductosEnCarrito)
        {
            int i = 0;
            foreach (var producto in datosObtenidos)
            {
                listaDeProductosEnCarrito[i] = new ListaDeProductosEnCarrito();
                listaDeProductosEnCarrito[i].IdProducto = $"{producto["ID"]}";
                listaDeProductosEnCarrito[i].NombreDelProducto = $"{producto["nombre"]}";
                listaDeProductosEnCarrito[i].ImagenCategoriaProducto = $"{producto["categoria"]}";
                listaDeProductosEnCarrito[i].CategoriaDelProducto = $"{producto["categoria"]}";
                listaDeProductosEnCarrito[i].PrecioUnitarioDelProducto = $"{producto["precio unitario"]}";
                listaDeProductosEnCarrito[i].CantidadDeseadaDelProducto = $"{producto["cantidad"]}";
                listaDeProductosEnCarrito[i].PrecioTotalDelProducto = $"{producto["precio total"]}";
                listaDeProductosEnCarrito[i].PublicadorDelProducto = $"{producto["publicador"]}";
                FlpProductosDelCarrito.Controls.Add(listaDeProductosEnCarrito[i]);
                i++;
            }
        }
        /// <summary>
        /// Método encargado de mostrar todos los productos dentro del archivo Carrito del usuario
        /// por el flow layout panel.
        /// </summary>
        internal void MostrarProductos()
        {
            FlpProductosDelCarrito.Controls.Clear();
            FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
            string compradorDelProducto = formIngreso.usuarioLoggeado;
            string ruta = $"..\\..\\..\\..\\Carrito\\Carrito{compradorDelProducto}.json";

            if (File.Exists(ruta))
            {
                SerializadorArchivos<List<Dictionary<string, object>>> serializadorArchivos = new SerializadorArchivos<List<Dictionary<string, object>>>();
                List<Dictionary<string, object>> datosObtenidos = new List<Dictionary<string, object>>();

                datosObtenidos = serializadorArchivos.Deserializar(ruta);  // Deserializo el contenido existente
                ListaDeProductosEnCarrito[] listaDeProductos = new ListaDeProductosEnCarrito[datosObtenidos.Count];
                AgregarProductosAlPanel(datosObtenidos, listaDeProductos);
            }
        }
        /// <summary>
        /// Metodo encargado de guardar los datos de la compra realizada del usuario
        /// en un archivo JSON, registrando la compra de productos.
        /// </summary>
        private void GuardarDatosDeCompra()
        {
            SerializadorArchivos<List<Dictionary<string, object>>> serializadorArchivos = new SerializadorArchivos<List<Dictionary<string, object>>>();
            FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
            List<Dictionary<string, object>> datosObtenidosCarrito = new List<Dictionary<string, object>>();
            List<Dictionary<string, object>> datosObtenidosCompras = new List<Dictionary<string, object>>();
            List<Dictionary<string, object>> datosAGuardar = new List<Dictionary<string, object>>();

            string compradorDelProducto = formIngreso.usuarioLoggeado;
            string rutaCarrito = $"..\\..\\..\\..\\Carrito\\Carrito{compradorDelProducto}.json";
            string rutaCompras = $"..\\..\\..\\..\\Compras\\Compras{compradorDelProducto}.json";
            datosObtenidosCarrito = serializadorArchivos.Deserializar(rutaCarrito);


            if (File.Exists(rutaCompras)) // Verifico si el archivo compras ya existe para cierto usuario
            {
                datosObtenidosCompras = serializadorArchivos.Deserializar(rutaCompras);
                foreach (var producto in datosObtenidosCompras) // Añado los datos que ya contenia el archivo compras
                {
                    datosAGuardar.Add(producto);
                }
                foreach (var producto in datosObtenidosCarrito) // Ahora añado los datos del carrito
                {
                    Dictionary<string, object> datos = new Dictionary<string, object>()
                    {
                        { "ID", producto["ID"] },
                        { "nombre", producto["nombre"] },
                        { "categoria", producto["categoria"] },
                        { "publicador", producto["publicador"] },
                        { "precio unitario", producto["precio unitario"] },
                        { "cantidad", producto["cantidad"]},
                        { "precio pagado",  producto["precio total"]},
                        { "fecha de compra", DateTime.Now.ToString() }
                    };

                    datosAGuardar.Add(datos);
                }
                serializadorArchivos.Serializar(datosAGuardar, rutaCompras); // Serializo los datos
            }
            else // Si el archivo no existe, creo uno con los datos del carrito.
            {
                foreach (var producto in datosObtenidosCarrito)
                {
                    Dictionary<string, object> datos = new Dictionary<string, object>()
                    {
                        { "ID", producto["ID"] },
                        { "nombre", producto["nombre"] },
                        { "categoria", producto["categoria"] },
                        { "publicador", producto["publicador"] },
                        { "precio unitario", producto["precio unitario"] },
                        { "cantidad", producto["cantidad"]},
                        { "precio pagado",  producto["precio total"]},
                        { "fecha de compra", DateTime.Now.ToString() }
                    };

                    datosAGuardar.Add(datos);
                }
                serializadorArchivos.Serializar(datosAGuardar, rutaCompras);
            }

        }
        /// <summary>
        /// Metodo encargado de guardar los datos de venta del usuario
        /// en un archivo JSON, registrando la compra de productos.
        /// </summary>
        private void GuardarDatosDeVenta()
        {
            SerializadorArchivos<List<Dictionary<string, object>>> serializadorArchivos = new SerializadorArchivos<List<Dictionary<string, object>>>();
            List<Dictionary<string, object>> datosObtenidosCarrito = new List<Dictionary<string, object>>();
            List<Dictionary<string, object>> datosObtenidosVentas = new List<Dictionary<string, object>>();
            List<Dictionary<string, object>> datosAGuardar = new List<Dictionary<string, object>>();

            FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
            string compradorDelProducto = formIngreso.usuarioLoggeado;

            string rutaCarrito = $"..\\..\\..\\..\\Carrito\\Carrito{compradorDelProducto}.json";

            datosObtenidosCarrito = serializadorArchivos.Deserializar(rutaCarrito);

            foreach (var producto in datosObtenidosCarrito)
            {
                Dictionary<string, object> datos = new Dictionary<string, object>()
                {
                    { "ID", producto["ID"] },
                    { "nombre", producto["nombre"] },
                    { "categoria", producto["categoria"] },
                    { "precio unitario", producto["precio unitario"] },
                    { "cantidad", producto["cantidad"] },
                    { "precio pagado",  producto["precio total"] },
                    { "comprador", compradorDelProducto },
                    { "fecha de compra", DateTime.Now.ToString() }
                };

                string rutaVentas = $"..\\..\\..\\..\\Ventas\\Ventas{producto["publicador"]}.json";
                datosAGuardar.Add(datos);

                if (File.Exists(rutaVentas)) // Agrego los datos a la lista de ventas del publicador actual
                {
                    datosObtenidosVentas = serializadorArchivos.Deserializar(rutaVentas);
                    datosObtenidosVentas.Add(datos);
                    serializadorArchivos.Serializar(datosObtenidosVentas, rutaVentas);
                }
                else
                {
                    serializadorArchivos.Serializar(new List<Dictionary<string, object>> { datos }, rutaVentas);
                }
            }
        }
        #endregion
    }
}
