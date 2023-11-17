using Entidades.BaseDeDatos;
using Entidades.Excepciones;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Usuario : Persona, IValidacionesUsuario
    {
        private string nombreUsuario;
        private string contraseña;

        public Usuario(string nombre, string apellido, string dni, string usuario, string contraseña)
            : base(nombre, apellido, dni)
        {
            this.nombreUsuario = ValidacionUsuario(usuario);
            this.contraseña = ValidacionContraseña(contraseña);
        }

        #region "Propiedades"
        public string NombreUsuario { get {return nombreUsuario; } }
        public string Contraseña { get {return contraseña; } }
        #endregion

        #region "Validaciones"
        /// <summary>
        /// Método encargado de validar que la contraseña ingressada sea una cadena de entre 3 y 12 carácteres
        /// y que no contenga espacios.
        /// </summary>
        /// <param name="contraseña">Contraseña a validar</param>
        /// <returns>
        /// Contraseña validada.
        /// </returns>
        /// <exception cref="ContraseñaInvalidaException"></exception>
        public string ValidacionContraseña(string contraseña)
        {
            if (contraseña.Length >= 3 && contraseña.Length <= 12) 
            {
                foreach (char c in contraseña)
                {
                    if (c == ' ')
                    {
                        throw new ContraseñaInvalidaException("Error. La contraseña no puede contener espacios en blanco.");
                    }
                }
                return contraseña;
            }
            else
            {
                throw new ContraseñaInvalidaException("Error. Ingrese una contraseña entre 3 y 12 carácteres.");
            }
        }
        /// <summary>
        /// Método encargado de validar que el usuario ingresado no sea nulo ni esté contenido solo de espacios vacios,
        /// que no haya un usuario con el mismo nombre, que no contenga espacios en blanco y que 
        /// sea una cadena que contenga entre 5 y 20 carácteres.
        /// </summary>
        /// <param name="usuario">Nombre de usuario a validar.</param>
        /// <returns>
        /// Usuario validado.
        /// </returns>
        /// <exception cref="UsuarioInvalidoException"></exception>
        public string ValidacionUsuario(string usuario)
        {
            if (string.IsNullOrWhiteSpace(usuario))
            {
                throw new UsuarioInvalidoException("Error. Ingrese un nombre de usuario.");
            }

            if (GestorPersonasSqlDelivered.VerificarExistenciaUsuario(usuario))
            {
                throw new UsuarioInvalidoException("Error. El nombre de usuario ingresado ya está en uso.");
            }

            if (usuario.Length >= 5 && usuario.Length <= 20)
            {
                foreach (char c in usuario)
                {
                    if (c == ' ')
                    {
                        throw new UsuarioInvalidoException("Error. El nombre de usuario no puede contener espacios en blanco.");
                    }
                }
                return usuario;
            }
            else
            {
                throw new UsuarioInvalidoException("Error. El nombre de usuario debe contener entre 5 y 20 caracteres.");
            }
        }
        #endregion
    }
}
