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
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
        }
        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
            LblSaludo.Text = $"Bienvenido {formIngreso.NombreDelUsuarioLoggeado}!";
        }
        private void BtnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnPublicarProducto_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormPublicarProductos());
        }
        private void BtnExplorarProductos_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormExplorarProductos());
        }
        private void BtnVerCarrito_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormCarrito());
        }
        private void BtnMisCompras_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormMisCompras());
        }
        private void BtnMisVentas_Click(object sender, EventArgs e)
        {
            AbrirForm(new FormMisVentas());
        }
        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
            formIngreso.Show();
            this.Close();
        }

        #region "Metodos"
        /// <summary>
        /// Método encargado de abrir un nuevo form dentro del panel contenedor del menu principal.
        /// </summary>
        /// <param name="formHijo">Form a abrir.</param>
        private void AbrirForm(object formHijo)
        {
            if (this.PanelContenedor.Controls.Count > 0) // Preguntamos si existe algun control en el panel.
            {
                this.PanelContenedor.Controls.RemoveAt(0); // De ser true, lo elimino.
            }
            Form fh = formHijo as Form;
            fh.TopLevel = false; // Será un formulario secundario.
            fh.Dock = DockStyle.Fill; // Se acoplará al panel ocupando su totalidad.
            this.PanelContenedor.Controls.Add(fh); // Agrego al form al panel.
            this.PanelContenedor.Tag = fh; // Establezco la instancia como contenedor de datos del panel.
            fh.Show();
        }

        #endregion

    }
}
