using System.Security.Cryptography;

namespace clasePersona;

public class Persona
{
    public string nombre;
    public float altura;
    public int edad;

    public Persona(string nombre, float altura, int edad)
    {
        this.nombre = nombre;
        this.altura = altura;
        this.edad = edad;
    }
}
