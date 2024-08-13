namespace Biblioteca;

public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string Domicilio { get; set; }

    public Persona (string Nombre, string Apellido, string Domicilio)
    {
        this.Nombre = Nombre;
        this.Apellido = Apellido;
        this.Domicilio = Domicilio;
    }
}
