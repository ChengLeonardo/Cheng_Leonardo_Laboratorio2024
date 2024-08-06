namespace BibliotecaActividad5;
public class Curso
{
    public required string Codigo {get; set;}
    public int Anio {get; set;}
    public int Division {get; set;}
    public int Ciclo_lectivo {get; set;}
    public List<Alumno> Alumnos = new List<Alumno>();

    public void InscribirAlumno(Alumno alumno)
    {
        Alumnos.Add(alumno);
    }
}
