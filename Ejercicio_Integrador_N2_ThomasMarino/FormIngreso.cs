using Entidades;

namespace Ejercicio_Integrador_N2_ThomasMarino
{
    public partial class FormIngreso : Form
    {
        public FormIngreso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.Show();
        }

        private void FormIngreso_Load(object sender, EventArgs e)
        {

        }

        private void FormIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GestorSql.LoggearUsuario(textBox1.Text))
            {
                MessageBox.Show("Loggee");
            }
            else
            {
                MessageBox.Show("No loggee");
            }
        }
    }
}