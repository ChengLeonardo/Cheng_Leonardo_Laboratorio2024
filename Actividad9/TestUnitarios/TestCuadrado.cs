using BilbiotecaClases;

namespace TestUnitarios;

public class TestCuadrado
{
    [Fact]
    public void CrearCuadradoConConstructorPositivo()
    {
        FiguraGeometrica cuadrado = new Cuadrado(3.5d);

        Assert.NotNull(cuadrado);
    }

    [Fact]
    public void CrearCuadradoVerificarPerimetro()
    {
        FiguraGeometrica cuadrado = new Cuadrado(3.5d);

        Assert.Equal(3.5d * 4, cuadrado.Perimetro);
    }

    [Fact]
    public void CrearCuadradoVerificarSuperficie()
    {
        FiguraGeometrica cuadrado = new Cuadrado(3.5d);
        Assert.Equal(3.5d * 3.5d, cuadrado.Superficie);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-3)]
    public void CrearCuadradoConConstructorAsegurandoException(int parametro)
    {
        Assert.Throws<Exception>(() => new Cuadrado(parametro));
    }
}