using Entidades.Modelos;
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
using static System.Windows.Forms.DataFormats;
using Entidades.BaseDeDatos;
using Entidades.Eventos;

namespace Ejercicio_Integrador_N2_ThomasMarino
{
    public partial class FormRegistro : Form
    {
        CreacionDeUsuario creacionDeUsuario;
        public FormRegistro()
        {
            InitializeComponent();
            creacionDeUsuario = new CreacionDeUsuario();
            creacionDeUsuario.OnCreacionDeUsuario += MostrarInformacionUsuarioGeneradoPorMSGBox; // Suscribo al metodo para que funcione.
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
            formIngreso.Show();
            this.Close();
        }

        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                creacionDeUsuario.CrearCuenta(TxbNombre.Text, TxbApellido.Text, TxbDNI.Text, TxbUsuario.Text, TxbContraseña.Text);
                FormIngreso formIngreso = Application.OpenForms.OfType<FormIngreso>().FirstOrDefault();
                formIngreso.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region "Métodos"
        private void MostrarInformacionUsuarioGeneradoPorMSGBox(string mensaje)
        {
            MessageBox.Show(mensaje, "Cuenta generada con éxito!");
        }
        #endregion

    }
}