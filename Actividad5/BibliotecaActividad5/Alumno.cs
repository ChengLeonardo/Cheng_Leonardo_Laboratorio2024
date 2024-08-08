namespace BibliotecaActividad5;

public class Alumno
{
    public required string Nombre {get; set;}
    public required string Apellido {get; set;}
    public int NumDocumento {get; set;}
    public TipoDocumento TipoDocumento {get; set;}

    public void InformarAlumno()
    {
        Console.WriteLine($"Nombre = {Nombre}, Apellido = {Apellido}, Numero Documento = {NumDocumento}, Tipo Documento = {TipoDocumento}");
    }
}