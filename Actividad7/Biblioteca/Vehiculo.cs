namespace Biblioteca;

public class Vehiculo
{
    public int NumeroSerieMotor { get; set;}
    public required string Marca { get; set;}
    public int Anio { get; set;}
    public decimal Precio { get; set;}
    public bool Combustion  { get; set;}
    public float Kilometraje { get; set;}
}
