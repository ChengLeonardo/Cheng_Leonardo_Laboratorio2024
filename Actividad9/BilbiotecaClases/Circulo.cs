namespace BilbiotecaClases;

public class Circulo : FiguraGeometrica
{
    private double _radio;
    public double Radio
    {
        get { return _radio; }
    }

    public Circulo(double num)
    {
        Verificacion.VerificarPositivo(num);
        _radio = num;
        _perimetro = Math.PI*2*num;
        _superficie = Math.PI*num*num;
    }
}