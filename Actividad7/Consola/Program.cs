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

AutoFamiliar autoFamiliar2 = new AutoFamiliar()
{
    Marca = "audo", 
    NumeroSerieMotor = 1,
    Anio = 101,
    Precio = 13143,
    Combustion = false,
    Kilometraje = 42342,
    CantidadPasajeros = 9,
    Tipo = "Familiar"
};

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

Consumo consumo1 = new Consumo(autoFamiliar1);
consumo.InformarConsumo();
Consumo consumo2 = new Consumo(autoFamiliar2);
consumo.InformarConsumo();
Consumo consumo3 = new Consumo(camioneta);
consumo.InformarConsumo();
