using System.Runtime.InteropServices;

namespace Biblioteca;

public class AutoFamiliar : Auto, IVehiculo
{ 
    public int CantidadPasajeros { get; set;}

    public float InformarConsumo()
    {
        if(Combustion == false)
        {
            return Kilometraje / 20;
        }
        else
        {
            return Kilometraje / 13;
        }
    }
}