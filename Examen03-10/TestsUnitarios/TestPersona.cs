using Biblioteca;

namespace TestsUnitarios
{
    public class TestPersona
    {
        [Theory]
        [InlineData("45")]
        [InlineData("0")]
        [InlineData("70.234")]
        [InlineData("43,234")]
        public void CrearPersonaEnEdadConEntero_Neutro_ConPunto_ConComa(string edad)
        {
            Persona persona  = new Persona("leonardo", edad);

            Assert.Equal(Convert.ToDouble(edad.Replace('.', ',')), persona.Edad);
        }

        [Theory]
        [InlineData("0", "Inactiva")]
        [InlineData("7", "Inactiva")]
        [InlineData("14", "Inactiva")]
        [InlineData("15", "Activa")]
        [InlineData("30", "Activa")]
        [InlineData("64", "Activa")]
        [InlineData("65", "Inactiva")]
        [InlineData("99", "Inactiva")]
        public void VefiricarGrupoEtarioEnDiferentesRangosDeEdad(string edad, string grupoEtario)
        {
            Persona persona  = new Persona("leonardo", edad);

            Assert.Equal(grupoEtario, persona.GrupoEtario);
        }

        [Theory]
        [InlineData("-4")]
        [InlineData("fasdf")]
        [InlineData("")]
        [InlineData("5,5,5")]
        [InlineData("5.5.5")]
        public void CrearPersonaEnEdadConNumeroNegativo_Cadena_Vacio_ConDosComas_ConDosPuntos(string edadIncorrecta)
        {
            Assert.ThrowsAny<Exception>(() => new Persona("leonardo", edadIncorrecta));
        }
    }
}