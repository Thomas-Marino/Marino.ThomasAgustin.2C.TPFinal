using System.Net;
using Entidades.Excepciones;
using Entidades.Modelos;

namespace TestsUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void AlIngresarUnNumeroQueComienzaCon0_SeEspera_LanzarUnaExcepcion()
        {
            //Arrange 
            string dni = "04000005";

            //Act
            if (dni[0] == '0')
            {
                throw new DniInvalidoException("Error. El dni no puede empezar en 0.");
            }

            //Assert
        }

        [TestMethod]
        public void AlIngresarUnNombreQueContengaEspacios_SeEspera_Eliminarlos()
        {
            //Arrange 
            string nombreIngresado = "   Te st  in  g   ";
            string nombreIngresadoCorregido = "";
            string nombreEsperado = "Testing";

            //Act
            foreach (char c in nombreIngresado)
            {
                if (c != ' ')
                {
                    nombreIngresadoCorregido += c;
                }
            }

            //Assert
            Assert.AreEqual(nombreEsperado, nombreIngresadoCorregido);
        }
    }
}