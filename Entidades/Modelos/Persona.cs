using Entidades.BaseDeDatos;
using Entidades.Excepciones;

namespace Entidades.Modelos
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;

        public string Nombre { get { return nombre; } }
        public string Apellido { get { return apellido; } }
        public int Dni { get {return dni; } }


        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = ValidacionNombre(nombre);
            this.apellido = ValidacionApellido(apellido);
            this.dni = ValidacionDni(dni);
        }

        #region "Validaciones"
        private string ValidacionNombre(string nombre)
        {
            if (!string.IsNullOrWhiteSpace(nombre)) 
            {
                if (nombre.Length > 30)
                {
                    throw new NombreinvalidoException("Error. El nombre ingresado es muy largo.");
                }
                foreach(char c in nombre)
                {
                    if (c != ' ' && !char.IsLetter(c))
                    {
                        throw new NombreinvalidoException("Error. El nombre solo debe contener letras.");
                    }
                }
                return nombre;
            }
            else
            {
                throw new NombreinvalidoException("Error. Ingrese un nombre.");
            }
        }
        private string ValidacionApellido(string apellido)
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
                return apellido;
            }
            else
            {
                throw new ApellidoInvalidoException("Error. Ingrese un apellido.");
            }
        }
        private int ValidacionDni(string dni)
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
        #endregion
    }
}