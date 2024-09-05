namespace Biblioteca;

public class CamionetaCombustible : AutoCombustible
{
    public float Capacidad { get; set; }
    public int CantidadEjes { get; set; }
    public override float InformarConsumo()
    {
        return Kilometraje / 10;
    }
}