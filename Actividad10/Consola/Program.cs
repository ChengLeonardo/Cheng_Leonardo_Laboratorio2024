using Biblioteca;
while(true)
{        
    Console.Write($"Ingrese su peso: ");
    string peso = Console.ReadLine();
    Console.Write($"Ingrese su altura: ");
    string altura = Console.ReadLine();
    try
    {
        Persona persona = new Persona(peso, altura);
        persona.Informar();
    }
    catch
    {
        continue;
    }
    
}