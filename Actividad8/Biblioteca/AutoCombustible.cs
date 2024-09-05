using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace Biblioteca;

public abstract class AutoCombustible : Auto, IConsumo
{
    public float VolumenTanque { get; set; } //carga de combustible

    public virtual float InformarConsumo()
    {
        return Kilometraje / 13;
    }
}