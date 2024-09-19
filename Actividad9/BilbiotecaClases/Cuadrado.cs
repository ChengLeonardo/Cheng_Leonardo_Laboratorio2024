using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;

namespace BilbiotecaClases;

public class Cuadrado : FiguraGeometrica
{
    private double _lado;
    public double Lado
    {
        get { return _lado; }
    }
    
    public Cuadrado(double Lado)
    {
        Verificacion.VerificarPositivo(Lado);
        _lado = Lado;
        _superficie = Lado*Lado;
        _perimetro = Lado * 4;
    }
}
