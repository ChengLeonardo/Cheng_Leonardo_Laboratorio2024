using Biblioteca;

namespace Test;

public class PersonaTest1
{
    [Fact]
    public void CrearPersonaCasoNormal()
    {
        string peso = "124";
        string altura = "1.5";
        
        Persona persona = new Persona(peso, altura);

        Assert.NotNull(persona);
    }

    [Theory]
    [InlineData("-1", "-53.3")]
    [InlineData("0", "0")]
    [InlineData("asdf", "fasdf")]
    [InlineData(" ", " ")]
    public void CrearPersonaConValoresNegativos_ValoresNulos_ValoresString_ValoresEmpty(string peso, string altura)
    {
        // Given
        // When 
        // Then
        Assert.Throws<Exception>(() => new Persona(peso, altura));
    }
}