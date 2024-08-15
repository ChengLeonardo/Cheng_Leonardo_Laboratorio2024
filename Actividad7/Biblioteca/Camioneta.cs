namespace Biblioteca;

public class Camioneta : Auto, IVehiculo
{
    public float Capacidad { get; set;} //kilogramos
    public int CantidadEjes { get; set;}
    public float InformarConsumo()
    {
        if(Combustion == false)
        {
            return Kilometraje / 20;
        }
        else
        {
            return Kilometraje / 10;
        }
    }
}