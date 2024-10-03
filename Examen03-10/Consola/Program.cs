using Biblioteca;


Console.Write("Ingrese su nombre:");
string nombre = Console.ReadLine();
Console.Write("Ingrese su edad:");
string edad = Console.ReadLine();

double edadConvertida;
while(true)
{
    if(Verificacion.VerificarTipoNumero(edad))
    {
        edadConvertida = Convert.ToDouble(edad);
        try
        {
            Verificacion.VerificarNumeroPositivo(edadConvertida);
        }
        catch
        {
            
        }
    }
    Console.WriteLine("El valor ingresado es incorrecto");
    Console.Write("Ingrese otro numero:");
    edad = Console.ReadLine();
}

Persona persona = new Persona(nombre , edad);
persona.InformarGrupoEtario();