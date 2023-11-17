using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.BaseDeDatos;
using Entidades.Modelos;

namespace Entidades.Eventos
{
    public delegate void DelegadoCreacionDeUsuario(string mensaje); // Genero el delegado
    public class CreacionDeUsuario
    {
        public event DelegadoCreacionDeUsuario OnCreacionDeUsuario; // Genero el evento

        /// <summary>
        /// Método encargado de ralizar la creación de la cuenta dentro de la base de datos.
        /// </summary>
        /// <param name="nombre">Nombre del titular de la cuenta.</param>
        /// <param name="apellido">Apellido del titular de la cuenta.</param>
        /// <param name="dni">Dni del titular de la cuenta.</param>
        /// <param name="nombreUsuario">Nombre del usuario del titular de la cuenta.</param>
        /// <param name="contraseña">Contraseña del usuario del titular de la cuenta.</param>
        public void CrearCuenta(string nombre, string apellido, string dni, string nombreUsuario, string contraseña)
        {
            Usuario usuario = new Usuario(nombre, apellido, dni, nombreUsuario, contraseña);
            GestorPersonasSqlDelivered.AñadirUsuario(usuario);

            if (OnCreacionDeUsuario != null)
            {
                OnCreacionDeUsuario.Invoke(MostrarInformacionUsuarioGenerado(usuario));
            }
        }
        /// <summary>
        /// Método encargado de mostrar los datos del usuario creado.
        /// </summary>
        /// <param name="usuario">Usuario creado</param>
        /// <returns>
        /// String que muestra la información de los datos del usuario.
        /// </returns>
        private string MostrarInformacionUsuarioGenerado(Usuario usuario)
        {
            return $"Nombre: {usuario.Nombre}\nApellido: {usuario.Apellido}\nDni: {usuario.Dni}\nusuario: {usuario.NombreUsuario}";
        }
    }
}
