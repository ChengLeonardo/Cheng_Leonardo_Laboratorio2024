using System.Diagnostics.Contracts;
using System.Dynamic;

namespace Biblioteca;

public class Persona
{
    public string Nombre { get; set; }
    public double Edad { get; set; }
    public string GrupoEtario { get; private set; }

    public Persona(string nombre, string edad)
    {
        edad = edad.Replace('.', ',');
        Edad = ConvertirEdad(edad);
        Nombre = nombre;
        ClasificarGrupoEtario();
    }

    public double ConvertirEdad(string edad)
    {
        double edadConvertida = Convert.ToDouble(edad);
        Verificacion.VerificarNumeroPositivo(edadConvertida);

        return edadConvertida;
    }

    public void InformarGrupoEtario()
    {
        Console.WriteLine($"{GrupoEtario} (en edad de trabajar)");
    }

    public void ClasificarGrupoEtario()
    {
        if(Edad >= 0 && Edad <= 14 || Edad >= 65)
        {
            GrupoEtario = "Inactiva";
        }
        else if(Edad >= 15 && Edad <= 64)
        {
            GrupoEtario = "Activa";
        }
    }
}