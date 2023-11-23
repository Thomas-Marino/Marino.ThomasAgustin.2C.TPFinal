namespace Ejercicio_Integrador_N2_ThomasMarino
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Task tareaCrearDirectoriosNecesarios = new Task(CrearDirectoriosNecesarios);
            tareaCrearDirectoriosNecesarios.Start();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormIngreso());
        }

        static void CrearDirectoriosNecesarios()
        {
            // Me aseguro de que esten creados los directorios necesarios para leer archivos.
            if (!Directory.Exists("..\\..\\..\\..\\Carrito"))
            {
                Directory.CreateDirectory("..\\..\\..\\..\\Carrito");
            }
            if (!Directory.Exists("..\\..\\..\\..\\Compras"))
            {
                Directory.CreateDirectory("..\\..\\..\\..\\Compras");
            }
            if (!Directory.Exists("..\\..\\..\\..\\Ventas"))
            {
                Directory.CreateDirectory("..\\..\\..\\..\\Ventas");
            }
        }
    }
}