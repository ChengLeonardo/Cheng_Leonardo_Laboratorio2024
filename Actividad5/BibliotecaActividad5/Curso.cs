namespace BibliotecaActividad5;
public class Curso
{
    public required string Codigo {get; set;}
    public int Anio {get; set;}
    public int Division {get; set;}
    public int Ciclo_lectivo {get; set;}
    public List<Alumno> Alumnos = new List<Alumno>();

    public void Curso(string codigo, int anio, int division, int ciclo_lectivo, List<Alumno> alumnos)
    {
        Codigo = codigo;
        Anio = anio;
        Division = division;
        Ciclo_lectivo = ciclo_lectivo;
        Alumnos = alumnos;
    }

    public void InscribirAlumno(Alumno alumno)
    {
        Alumnos.add(alumno);
    }
}
