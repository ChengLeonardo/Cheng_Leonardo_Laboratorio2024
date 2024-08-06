using BibliotecaActividad5;

Console.Write("Ingrese el codigo del Curso: ");
nombre = Console.ReadLine();
List<string> codigo_Cursos = new List<string>();

while (codigo_Curso != "")
{
    if(codigo_Cursos.Contains(codigo_Curso))
    {
        Console.Write("Ingrese el nombre del alumno: ");
        string nombre = Console.ReadLine();
        
        Console.Write("Ingrese el apellido del alumno: ")
        string apellido = Console.ReadLine();

        Console.Write("Ingrese el numero de documento del alumno: ");
        int numero_Documento = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Ingrese el tipo de documento del alumno: ");
        string tipoDocumento = Console.ReadLine();

        Alumno alumno = new Alumno(nombre, apellido, numero_Documento, tipoDocumento);

    }
    Console.Write("Ingrese el anio del curso: ");
    string anio = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingrese la division del curso: ");
    int division = Convert.ToInt16(Console.ReadLine());

    Console.Write("Ingrese el ciclo lectivo del curso: ");
    int ciclo_lectivo = Convert.ToInt16(Console.ReadLine());

    codigo_Cursos.add(codigo_Curso)

    Console.Write("Si quiere seguir ingresar otro curso, ingrese un nuevo codigo, si quiere ingresar los alumnos del curso creado, ingrese el codigo de un curso existente, y si quiere parar el programa, no ingrese nada: ")
    codigo_Curso = Console.ReadLine();
}