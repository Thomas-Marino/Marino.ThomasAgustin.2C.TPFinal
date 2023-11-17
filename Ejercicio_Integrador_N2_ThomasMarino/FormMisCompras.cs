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
    public partial class FormMisCompras : Form
    {
        public FormMisCompras()
        {
            InitializeComponent();
        }

        private void FormMisCompras_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        #region "Metodos"
        private void AgregarProductosAlPanel(List<Dictionary<string, object>> datosObtenidos, ListaDeProductosComprados[] listaDeProductosComprados)
        {
            int i = 0;
            foreach (var producto in datosObtenidos)
            {
                listaDeProductosComprados[i] = new ListaDeProductosComprados();
                listaDeProductosComprados[i].IdProducto = $"{producto["ID"]}";
                listaDeProductosComprados[i].NombreDelProducto = $"{producto["nombre"]}";
                listaDeProductosComprados[i].ImagenCategoriaProducto = $"{producto["categoria"]}";
                listaDeProductosComprados[i].CategoriaDelProducto = $"{producto["categoria"]}";
                listaDeProductosComprados[i].PrecioUnitarioDelProducto = $"{producto["precio unitario"]}";
                listaDeProductosComprados[i].CantidadCompradaDelProducto = $"{producto["cantidad"]}";
                listaDeProductosComprados[i].PrecioTotalPagado = $"{producto["precio pagado"]}";
                listaDeProductosComprados[i].PublicadorDelProducto = $"{producto["publicador"]}";
                listaDeProductosComprados[i].FechaDeCompra = $"{producto["fecha de compra"]}";

                FlpProductosComprados.Controls.Add(listaDeProductosComprados[i]);
                i++;
            }
        }
        internal void MostrarProductos()
        {
            FlpProductosComprados.Controls.Clear();
            FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
            string compradorDelProducto = formIngreso.usuarioLoggeado;
            string ruta = $"..\\..\\..\\..\\Compras\\Compras{compradorDelProducto}.json";

            if (File.Exists(ruta))
            {
                SerializadorArchivos<List<Dictionary<string, object>>> serializadorArchivos = new SerializadorArchivos<List<Dictionary<string, object>>>();
                List<Dictionary<string, object>> datosObtenidos = new List<Dictionary<string, object>>();

                datosObtenidos = serializadorArchivos.Deserializar(ruta);  // Deserializo el contenido existente
                ListaDeProductosComprados[] listaDeProductos = new ListaDeProductosComprados[datosObtenidos.Count];
                AgregarProductosAlPanel(datosObtenidos, listaDeProductos);
            }
        }
        #endregion
    }
}
