using Entidades.BaseDeDatos;
using Entidades.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Usuario : Persona
    {
        private string nombreUsuario;
        private string contraseña;
        public string NombreUsuario { get {return nombreUsuario; } }
        public string Contraseña { get {return contraseña; } }

        public Usuario(string nombre, string apellido, string dni, string usuario, string contraseña)
            : base(nombre, apellido, dni)
        {
            this.nombreUsuario = ValidacionUsuario(usuario);
            // Validar que el usuario no se repita.
            this.contraseña = ValidacionContraseña(contraseña);
        }

        #region "Validaciones"
        private string ValidacionContraseña(string contraseña)
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

        private string ValidacionUsuario(string usuario)
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
