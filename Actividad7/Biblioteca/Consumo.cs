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

  public void InformarConsumo(IVehiculo vehiculo)
  {
    if(vehiculo.Combustible)
    {
      Console.WriteLine($"Consumo del vehiculo: {vehiculo.InformarConsumo()} litros");
    }
    else
    {
      Console.WriteLine($"Consumo del vehiculo: {vehiculo.InformarConsumo()} kWh");
    }
}
