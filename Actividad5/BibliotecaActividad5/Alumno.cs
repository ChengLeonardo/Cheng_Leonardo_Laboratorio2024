namespace BibliotecaActividad5;

public class Alumno
{
    public required string Nombre {get; set;}
    public required string Apellido {get; set;}
    public int NumDocumento {get; set;}
    public string TipoDocumento {get; set;}

    public void Alumno(string nombre, string apellido, int numdocumento, string tipoDocumento)
    {
        Nombre = nombre;
        Apellido = apellido;
        NumDocumento = numdocumento;
        TipoDocumento = tipoDocumento;
    }

    public void InformarAlumno()
    {
        Console.WriteLine($"Nombre = {Nombre}, Apellido = {Apellido}, Numero Documento = {NumDocumento}, Tipo Documento = {TipoDocumento}")
    }
}