using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IVehiculo
    {
        int NumeroSerieMotor { get; set;}
        string Marca { get; set;}
        int Anio { get; set;}
        decimal Precio { get; set;}
        bool Combustion  { get; set;}
        float Kilometraje { get; set;}
        float InformarConsumo();
    }
}