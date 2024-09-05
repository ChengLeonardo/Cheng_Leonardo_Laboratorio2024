using Biblioteca;

AutoCombustible auto1 = new AutoFamiliarCombustible
{
    Marca = "peugos",
    Tipo = "uno",
    Anio = 233,
    CantidadPasajeros = 2,
    Color = "azul",
    Kilometraje = 1000,
    NumeroSerieMotor = 3,
    Precio = 2342342,
    VolumenTanque = 2342
};

void InformarConsumoGeneral(IConsumo auto)
{
    Console.WriteLine(auto.InformarConsumo());
}
InformarConsumoGeneral(auto1);
InformarConsumoCombustible(auto1);

AutoElectrico auto1ele = new AutoFamiliarElectrico
{
    Marca = "peugos",
    Tipo = "uno",
    Anio = 233,
    CantidadPasajeros = 2,
    Color = "azul",
    Kilometraje = 1000,
    NumeroSerieMotor = 3,
    Precio = 2342342
};

InformarConsumoAutoElectrico(auto1ele);
InformarConsumoGeneral(auto1ele);

AutoElectrico auto2 = new AutoLujoElectrico
{
    Marca = "audi",
    Anio = 1234,
    Tipo = "lujo",
    Color = "negro",
    DimensionCargaBateria = 2342,
    Kilometraje = 23423,
    NumeroSerieMotor = 234343,
    Precio = 342343234
};

InformarConsumoGeneral(auto2);

void InformarConsumoAutoElectrico(AutoElectrico autoElectrico)
{
    Console.WriteLine(autoElectrico.InformarConsumo());
}

InformarConsumoAutoElectrico(auto2);


AutoCombustible camioneta = new CamionetaCombustible
{ 
    Marca = "nose",
    Tipo = "idn", 
    Anio = 1234, 
    CantidadEjes = 8, 
    Capacidad = 3423, 
    Color = "rojo", 
    Kilometraje = 23434, 
    NumeroSerieMotor = 3432, 
    Precio = 12312, 
    VolumenTanque = 12342
};

InformarConsumoGeneral(camioneta);

void InformarConsumoCombustible(AutoCombustible autoCombustible)
{
    Console.WriteLine(autoCombustible.InformarConsumo());
}

InformarConsumoCombustible(camioneta);

AutoElectrico camioneta2 = new CamionetaElectrica
{ 
    Marca = "nose",
    Tipo = "idn", 
    Anio = 1234, 
    CantidadEjes = 8, 
    Capacidad = 3423, 
    Color = "rojo", 
    Kilometraje = 23434, 
    NumeroSerieMotor = 3432, 
    Precio = 12312
};

InformarConsumoAutoElectrico(camioneta2);
InformarConsumoGeneral(camioneta2);