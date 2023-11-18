using Entidades.Archivos;
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
    public partial class FormMisVentas : Form
    {
        public FormMisVentas()
        {
            InitializeComponent();
        }

        private void FormMisVentas_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        #region "Métodos"
        /// <summary>
        /// Método encargado de añadir los productos vendidos por el usuario al panel.
        /// </summary>
        /// <param name="datosObtenidos">Productos obtenidos del archivo json</param>
        /// <param name="listaDeProductosVendidos">Lista de listaDeProductosVendidos(UserControl.)</param>
        private void AgregarProductosAlPanel(List<Dictionary<string, object>> datosObtenidos, ListaDeProductosVendidos[] listaDeProductosVendidos)
        {
            int i = 0;
            foreach (var producto in datosObtenidos)
            {
                listaDeProductosVendidos[i] = new ListaDeProductosVendidos();
                listaDeProductosVendidos[i].IdProducto = $"{producto["ID"]}";
                listaDeProductosVendidos[i].NombreDelProductoVendido = $"{producto["nombre"]}";
                listaDeProductosVendidos[i].ImagenCategoriaProducto = $"{producto["categoria"]}";
                listaDeProductosVendidos[i].CategoriaDelProducto = $"{producto["categoria"]}";
                listaDeProductosVendidos[i].PrecioUnitarioDelProducto = $"{producto["precio unitario"]}";
                listaDeProductosVendidos[i].CantidadVendidaDelProducto = $"{producto["cantidad"]}";
                listaDeProductosVendidos[i].PrecioTotalPagado = $"{producto["precio pagado"]}";
                listaDeProductosVendidos[i].CompradorDelProducto = $"{producto["comprador"]}";
                listaDeProductosVendidos[i].FechaDeCompra = $"{producto["fecha de compra"]}";

                FlpProductosVendidos.Controls.Add(listaDeProductosVendidos[i]);
                i++;
            }
        }
        /// <summary>
        /// Método encargado de mostrar en el panel todos los productos vendidos del usuario.
        /// </summary>
        internal void MostrarProductos()
        {
            FlpProductosVendidos.Controls.Clear();
            FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
            string vendedor = formIngreso.usuarioLoggeado;
            string ruta = $"..\\..\\..\\..\\Ventas\\Ventas{vendedor}.json";

            if (File.Exists(ruta))
            {
                SerializadorArchivos<List<Dictionary<string, object>>> serializadorArchivos = new SerializadorArchivos<List<Dictionary<string, object>>>();
                List<Dictionary<string, object>> datosObtenidos = new List<Dictionary<string, object>>();

                datosObtenidos = serializadorArchivos.Deserializar(ruta);  // Deserializo el contenido existente
                ListaDeProductosVendidos[] listaDeProductos = new ListaDeProductosVendidos[datosObtenidos.Count];
                AgregarProductosAlPanel(datosObtenidos, listaDeProductos);
            }
        }
        #endregion
    }
}
