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

        private void AgregarProductosAlPanel(List<Dictionary<string, object>> datosObtenidos, ListaDeProductosVendidos[] listaDeProductosComprados)
        {
            int i = 0;
            foreach (var producto in datosObtenidos)
            {
                listaDeProductosComprados[i] = new ListaDeProductosVendidos();
                listaDeProductosComprados[i].IdProducto = $"{producto["ID"]}";
                listaDeProductosComprados[i].NombreDelProductoVendido = $"{producto["nombre"]}";
                listaDeProductosComprados[i].ImagenCategoriaProducto = $"{producto["categoria"]}";
                listaDeProductosComprados[i].CategoriaDelProducto = $"{producto["categoria"]}";
                listaDeProductosComprados[i].PrecioUnitarioDelProducto = $"{producto["precio unitario"]}";
                listaDeProductosComprados[i].CantidadVendidaDelProducto = $"{producto["cantidad"]}";
                listaDeProductosComprados[i].PrecioTotalPagado = $"{producto["precio pagado"]}";
                listaDeProductosComprados[i].CompradorDelProducto = $"{producto["comprador"]}";
                listaDeProductosComprados[i].FechaDeCompra = $"{producto["fecha de compra"]}";

                FlpProductosVendidos.Controls.Add(listaDeProductosComprados[i]);
                i++;
            }
        }
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
    }
}
