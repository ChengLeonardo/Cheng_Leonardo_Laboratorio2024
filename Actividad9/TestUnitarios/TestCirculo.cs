using System.Formats.Asn1;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using BilbiotecaClases;

namespace TestUnitarios;

public class TestCirculo
{
    [Fact]
    public void CrearCirculoConConstructorPositivo()
    {
        FiguraGeometrica circulo = new Circulo(3.5d);

        Assert.NotNull(circulo);
    }

    [Fact]
    public void CrearCirculoVerificarPerimetro()
    {
        FiguraGeometrica circulo = new Circulo(3.5d);

        Assert.Equal(Math.PI*2*3.5d, circulo.Perimetro);
    }

    [Fact]
    public void CrearCirculoVerificarSuperficie()
    {
        FiguraGeometrica circulo = new Circulo(3.5d);
        Assert.Equal(Math.PI*3.5d*3.5d, circulo.Superficie);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-3)]
    public void CrearCirculoConConstructorAsegurandoException(int parametro)
    {
        Assert.Throws<Exception>(() => new Circulo(parametro));
    }
}