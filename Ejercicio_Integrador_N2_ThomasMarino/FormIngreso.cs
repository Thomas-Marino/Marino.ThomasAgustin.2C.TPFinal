using Entidades.BaseDeDatos;
using Entidades.Modelos;

namespace Ejercicio_Integrador_N2_ThomasMarino
{
    public partial class FormIngreso : Form
    {
        public string NombreDelUsuarioLoggeado;
        public string usuarioLoggeado;
        public FormIngreso()
        {
            InitializeComponent();
        }
        private void FormIngreso_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (GestorPersonasSqlDelivered.LoggearCuenta(TxbLoginUsuario.Text, TxbLoginContraseña.Text))
            {
                FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
                this.NombreDelUsuarioLoggeado = GestorPersonasSqlDelivered.ObtenerNombreDelUsuario(TxbLoginUsuario.Text);
                this.usuarioLoggeado = TxbLoginUsuario.Text;
                formMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credenciales invalidas.");
            }
        }
        private void FormIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}