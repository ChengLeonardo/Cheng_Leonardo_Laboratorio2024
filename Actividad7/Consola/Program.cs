using Biblioteca;
using Microsoft.VisualBasic;

AutoFamiliar autoFamiliar1 = new AutoFamiliar()
{
    Marca = "audi", 
    NumeroSerieMotor = 1,
    Anio = 101,
    Precio = 13143,
    Combustion = true,
    Kilometraje = 42342,
    CantidadPasajeros = 9,
    Tipo = "Familiar"
};

InformarConsumo(autoFamiliar1);


Auto auto = new Auto()
{
    Marca = "Tesla",
    NumeroSerieMotor = 3,
    Anio = 2020,
    Precio = 134234,
    Combustion = false,
    Kilometraje = 234234,
    Tipo = "Lujo"
};

InformarConsumo(auto);


Camioneta camioneta = new Camioneta
{
    Marca = "Peugeot",
    NumeroSerieMotor = 23,
    Anio = 1234,
    Precio = 2342,
    Combustion = true,
    Kilometraje = 23423423,
    Tipo = "Camioneta",
    Capacidad = 2342
};

InformarConsumo(camioneta);

void InformarConsumo(Auto vehiculo)
{
    float vehiculoConsumo = vehiculo.InformarConsumo();
    if(vehiculo.Combustion)
    {
        System.Console.WriteLine($"Consumo del auto: {vehiculoConsumo} litros de combustion");
    }
    else
    {
        System.Console.WriteLine($"Consumo del auto: {vehiculoConsumo} kWh de electricidad");
    }
}