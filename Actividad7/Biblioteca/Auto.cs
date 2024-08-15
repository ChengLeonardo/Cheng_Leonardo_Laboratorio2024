namespace Biblioteca;
public class Auto : Vehiculo
{
    public required string Tipo { get; set; }

    public float InformarConsumo()
    {
        if(Combustion == false)
        {
            return Kilometraje / 10;
        }
        else
        {
            if(Tipo == "Camioneta")
            {
                return Kilometraje / 10;
            }
            else
            {
                return Kilometraje / 13;
            }
        }
    }
}