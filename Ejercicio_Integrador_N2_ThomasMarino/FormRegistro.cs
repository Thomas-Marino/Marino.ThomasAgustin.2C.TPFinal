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

namespace Ejercicio_Integrador_N2_ThomasMarino
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCrearCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario(TxbNombre.Text, TxbApellido.Text, TxbDNI.Text, TxbUsuario.Text, TxbContraseña.Text);
                GestorPersonasSqlDelivered.CrearNuevaCuenta(usuario);
                MessageBox.Show($"Nombre: {usuario.Nombre}\nApellido: {usuario.Apellido}\nDni: {usuario.Dni}\nusuario: {usuario.NombreUsuario}", "Cuenta generada con éxito!");
                this.Close();
            }
            catch (NombreinvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ApellidoInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DniInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UsuarioInvalidoException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ContraseñaInvalidaException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (BaseDeDatosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
