using Entidades.BaseDeDatos;
using Entidades.Modelos;
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
    public partial class FormExplorarProductos : Form
    {
        private string categoria = null;
        private string nombreAFiltrar = null;
        private string publicadorAFiltrar = null;
        private string orden = null;


        public FormExplorarProductos()
        {
            InitializeComponent();
        }

        private void FormExplorarProductos_Load(object sender, EventArgs e)
        {
            RdbFiltrarVerTodo.Focus();
            MostrarProductos();
        }
        private void BtnAplicarFiltros_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            FiltrarProductos();
        }
        private void BtnBorrarFiltros_Click(object sender, EventArgs e)
        {
            TxbFiltrarNombre.ResetText();
            TxbFiltrarPublicador.ResetText();
        }
        private void CbFiltrarPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.orden = CbFiltrarPrecio.Text;
        }
        #region "RadioButtons"
        private void RdbFiltrarVerTodo_Click(object sender, EventArgs e)
        {
            categoria = RdbFiltrarVerTodo.Text;
        }
        private void RdbFiltrarTecnologia_Click(object sender, EventArgs e)
        {
            categoria = RdbFiltrarTecnologia.Text;
        }
        private void RdbFiltrarMuebles_Click(object sender, EventArgs e)
        {
            categoria = RdbFiltrarMuebles.Text;
        }
        private void RdbFiltrarHerramientas_Click(object sender, EventArgs e)
        {
            categoria = RdbFiltrarHerramientas.Text;
        }
        private void RdbFiltrarVehiculos_Click(object sender, EventArgs e)
        {
            categoria = RdbFiltrarVehiculos.Text;
        }
        #endregion

        #region "Metodos propios"
        /// <summary>
        /// Método encargado de filtrar los productos y agregarlos en el panel.
        /// </summary>
        private void FiltrarProductos()
        {
            flowLayoutPanel1.Controls.Clear();

            if (TxbFiltrarNombre.Text != null)
            {
                this.nombreAFiltrar = TxbFiltrarNombre.Text;
            }

            if (TxbFiltrarPublicador.Text != null)
            {
                this.publicadorAFiltrar = TxbFiltrarPublicador.Text;
            }
            List<Dictionary<string, object>> productosObtenidos = new List<Dictionary<string, object>>();
            productosObtenidos = GestorProductosSqlDelivered.ObtenerProductosFiltrados(this.categoria, this.nombreAFiltrar, this.publicadorAFiltrar, this.orden);
            ListaDeProductos[] listaDeProductos = new ListaDeProductos[productosObtenidos.Count];

            AgregarProductosAlPanel(productosObtenidos, listaDeProductos);
        }
        /// <summary>
        /// Método encargado de mostrar todos los productos en el panel.
        /// </summary>
        private void MostrarProductos()
        {
            List<Dictionary<string, object>> productosObtenidos = new List<Dictionary<string, object>>();
            productosObtenidos = GestorProductosSqlDelivered.ObtenerTodosLosProductos();
            ListaDeProductos[] listaDeProductos = new ListaDeProductos[productosObtenidos.Count];
            AgregarProductosAlPanel(productosObtenidos, listaDeProductos);
        }
        /// <summary>
        /// Método encargado de añadir los productos contenidos en una lista de diccionarios al panel.
        /// </summary>
        /// <param name="productosObtenidos">Productos obtenidos de la base de datos.</param>
        /// <param name="listaDeProductos">Lista de listaDeProductos(UserControl.)</param>
        private void AgregarProductosAlPanel(List<Dictionary<string, object>> productosObtenidos, ListaDeProductos[] listaDeProductos)
        {
            int i = 0;
            foreach (var producto in productosObtenidos)
            {
                if ((int)producto["stockDelProducto"] != 0)
                {
                    listaDeProductos[i] = new ListaDeProductos();
                    listaDeProductos[i].IdProducto = $"{producto["ID"]}";
                    listaDeProductos[i].NombreDelProducto = (string)producto["nombreDelProducto"];
                    listaDeProductos[i].ImagenCategoriaProducto = (string)producto["categoriaDelProducto"];
                    listaDeProductos[i].CategoriaDelProducto = (string)producto["categoriaDelProducto"];
                    listaDeProductos[i].PrecioDelProducto = $"{producto["precioDelProducto"]}";
                    listaDeProductos[i].StockDelProducto = $"{producto["stockDelProducto"]}";
                    listaDeProductos[i].PublicadorDelProducto = $"{producto["publicadorDelProducto"]}";
                    listaDeProductos[i].AsignarLimiteDeCompra(Convert.ToDecimal(producto["stockDelProducto"]));
                    flowLayoutPanel1.Controls.Add(listaDeProductos[i]);
                }
                i++;
            }
        }
        #endregion
    }
}
