using Entidades.BaseDeDatos;
using Entidades.Excepciones;
using Entidades.Interfaces;

namespace Entidades.Modelos
{
    public class Persona : IValidacionesPersona
    {
        private string nombre;
        private string apellido;
        private int dni;

        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = ValidacionNombre(nombre);
            this.apellido = ValidacionApellido(apellido);
            this.dni = ValidacionDni(dni);
        }

        #region "Propiedades"
        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public int Dni { get {return dni; } }
        #endregion

        #region "Validaciones"
        /// <summary>
        /// Método encargado de validar que el nombre ingresado no esté contenido de espacios en blanco ni sea nulo,
        /// que su longitud no sea mayor a 30 y que no tenga caracteres invalidos.
        /// </summary>
        /// <param name="nombre">Nombre a ingresar</param>
        /// <returns>
        /// Nombre validado.
        /// </returns>
        /// <exception cref="NombreinvalidoException"></exception>
        /// 
        public string ValidacionNombre(string nombre)
        {
            if (!string.IsNullOrWhiteSpace(nombre)) 
            {
                if (nombre.Length > 30)
                {
                    throw new NombreinvalidoException("Error. El nombre ingresado es muy largo.");
                }
                foreach (char c in nombre)
                {
                    if (c != ' ' && !char.IsLetter(c))
                    {
                        throw new NombreinvalidoException("Error. El nombre solo debe contener letras.");
                    }
                }

                return EliminarEspacios(nombre);
            }
            else
            {
                throw new NombreinvalidoException("Error. Ingrese un nombre.");
            }
        }
        /// <summary>
        /// Método encargado de validar que el apellido ingresado no esté contenido de espacios en blanco ni sea nulo,
        /// que su longitud no sea mayor a 30 y que no tenga caracteres invalidos.
        /// </summary>
        /// <param name="apellido">Apellido a ingresar.</param>
        /// <returns>
        /// Apellido validado.
        /// </returns>
        /// <exception cref="ApellidoInvalidoException"></exception>
        public string ValidacionApellido(string apellido)
        {
            if (!string.IsNullOrWhiteSpace(apellido))
            {
                if (apellido.Length > 30)
                {
                    throw new ApellidoInvalidoException("Error. El apellido es muy largo.");
                }
                foreach (char c in apellido)
                {
                    if (c != ' ' && !char.IsLetter(c))
                    {
                        throw new ApellidoInvalidoException("Error. El apellido solo debe contener letras.");
                    }
                }
                return EliminarEspacios(nombre);
            }
            else
            {
                throw new ApellidoInvalidoException("Error. Ingrese un apellido.");
            }
        }
        /// <summary>
        /// Método encargado de validar que el dni ingresado tenga una longitud de 7 u 8 números,
        /// que no contenga carácteres inválidos ni que comience con 0
        /// </summary>
        /// <param name="dni">Dni a validar</param>
        /// <returns>
        /// Dni validado.
        /// </returns>
        /// <exception cref="DniInvalidoException"></exception>
        public int ValidacionDni(string dni)
        {
            if (dni.Length == 8 || dni.Length == 7) 
            {
                bool primerCaracter = true;
                foreach (char c in dni)
                {
                    if (c == '0' && primerCaracter)
                    {
                        throw new DniInvalidoException("Error. El dni no puede empezar en 0.");
                    }
                    primerCaracter = false;
                }

                try
                {
                    if(GestorPersonasSqlDelivered.VerificarExistenciaDni(int.Parse(dni)))
                    {
                        throw new DniInvalidoException("Error. Usted ya tiene una cuenta.");
                    }
                    return int.Parse(dni);
                }
                catch (FormatException)
                {
                    throw new DniInvalidoException("Error en el ingreso del DNI. Debe contener solo números");
                }
            }
            else
            {
                throw new DniInvalidoException("Error en el ingreso del DNI. Cantidad de caracteres invalida.");
            }
        }
        /// <summary>
        /// Método encargado de eliminar los espacios dentro de los strings.
        /// </summary>
        /// <param name="stringIngresado">string a eeliminar espacios.</param>
        /// <returns>
        /// String ingresado sin espacios
        /// </returns>
        private string EliminarEspacios(string stringIngresado)
        {
            string stringIngresadoCorregido = "";
            
            foreach (char c in stringIngresado)
            {
                if (c != ' ')
                {
                    stringIngresadoCorregido += c;
                }
            }
            return stringIngresadoCorregido;
        }
        #endregion
    }
}