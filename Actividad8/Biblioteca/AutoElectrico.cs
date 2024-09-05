namespace Biblioteca;

public abstract class AutoElectrico : Auto, IConsumo
{
    public int DimensionCargaBateria { get; set; }

    public float InformarConsumo()
    {
        return Kilometraje / 20;
    }
}