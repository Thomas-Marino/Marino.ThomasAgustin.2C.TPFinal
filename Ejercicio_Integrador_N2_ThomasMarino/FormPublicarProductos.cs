using Entidades.BaseDeDatos;
using Entidades.Excepciones;
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
    public partial class FormPublicarProductos : Form
    {
        public FormPublicarProductos()
        {
            InitializeComponent();
        }

        private void BtnAltaDeProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto producto = new Producto(TxbNombreProducto.Text, CbCategoríaProducto.Text, TxbPrecioProducto.Text, TxbStockProducto.Text);
                FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
                GestorProductosSqlDelivered.CrearNuevoProducto(producto, formIngreso.usuarioLoggeado);
                MessageBox.Show($"Nombre: {producto.NombreDelProducto}.\nCategoria: {producto.CategoriaDelProducto}.\nPrecio: {producto.PrecioDelProducto}.\nStock: {producto.StockDelProducto}.", "Producto generado con éxito!");
                TxbNombreProducto.ResetText();
                CbCategoríaProducto.ResetText();
                TxbPrecioProducto.ResetText();
                TxbStockProducto.ResetText();
            }
            catch (NombreProductoInvalidoException ex)
            {
                TxbNombreProducto.ForeColor = Color.Red;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CategoriaDeProductoInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (PrecioDelProductoInvalidoException ex)
            {
                TxbPrecioProducto.ForeColor = Color.Red;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (StockProductoInvalidoException ex)
            {
                TxbStockProducto.ForeColor = Color.Red;
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (BaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxbNombreProducto_TextChanged(object sender, EventArgs e)
        {
            if (TxbNombreProducto.ForeColor == Color.Red)
            {
                TxbNombreProducto.ForeColor = Color.Black;
            }
        }

        private void TxbPrecioProducto_TextChanged(object sender, EventArgs e)
        {
            if (TxbPrecioProducto.ForeColor == Color.Red)
            {
                TxbPrecioProducto.ForeColor = Color.Black;
            }
        }

        private void TxbStockProducto_TextChanged(object sender, EventArgs e)
        {
            if (TxbStockProducto.ForeColor == Color.Red)
            {
                TxbStockProducto.ForeColor = Color.Black;
            }
        }
    }
}
