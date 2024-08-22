namespace Biblioteca;
public class Consumo
{
  private readonly IVehiculo _vehiculo;

  public Consumo(IVehiculo vehiculo)
  {
    if(vehiculo == null)
    {
      throw new Exception ("Vehiculo es nulo");
    }
    else
    {
      _vehiculo = vehiculo;
    }
  }

  public void InformarConsumo()
  {
    System.Console.WriteLine($"Consumo total del vehiculo: {_vehiculo.InformarConsumo()}"); 
  }
}
