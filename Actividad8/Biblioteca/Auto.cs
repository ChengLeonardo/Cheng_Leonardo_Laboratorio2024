namespace Biblioteca;
public abstract class Auto
{
    public int NumeroSerieMotor { get; set;}
    public required string Marca { get; set;}
    public int Anio { get; set;}
    public decimal Precio { get; set;}
    public float Kilometraje { get; set;}
    public required string Tipo { get; set; }
    public string Color { get; set; }

}