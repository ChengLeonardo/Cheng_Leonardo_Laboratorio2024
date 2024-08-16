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
      vehiculo.InformarConsumo();
  }
}
