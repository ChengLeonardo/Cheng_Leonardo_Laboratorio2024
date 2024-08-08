using BibliotecaActividad5;

List<Escuela> escuelas = new List<Escuela>();

List<TipoDocumento> tipoDocumentos = new List<TipoDocumento>();

TipoDocumento dni = new TipoDocumento()
{
    Nombre = "dni"
};

tipoDocumentos.Add(dni);

TipoDocumento dni2 = new TipoDocumento()
{
    Nombre = "dni2"
};

tipoDocumentos.Add(dni2);

TipoDocumento dni3 = new TipoDocumento()
{
    Nombre = "dni3"
};

tipoDocumentos.Add(dni3);

while (true)
{

    MostrarMenu();

    string opcion = ElegirOpcion();

    ControlOpcion(opcion, escuelas, tipoDocumentos);

}

void MostrarMenu()
{
    Console.WriteLine("\nMenú Principal");
    Console.WriteLine("\n1. Inscribir Escuela");
    Console.WriteLine("\n2. Inscribir Curso");
    Console.WriteLine("\n3. Inscribir Alumno");
    Console.WriteLine("\n4. Mostrar Cursos");
    Console.WriteLine("\n5. Mostrar Alumnos");
    Console.WriteLine("\n6. Salir");
    Console.Write("Seleccione una opción: ");
}

string ElegirOpcion()
{
    string opcion = Console.ReadLine();
    
    return opcion;
}

void ControlOpcion(string opcion, List<Escuela> escuelas, List<TipoDocumento> tipoDocumentos)
{
    switch (opcion)
        {
            case "1":
                InscribirEscuela(escuelas);
                break;
            case "2":
                InscribirCurso(escuelas);
                break;
            case "3":
                InscribirAlumno(escuelas, tipoDocumentos);
                break;
            case "4":
                MostrarCursos(escuelas);
                break;
            case "5":
                MostrarAlumnos(escuelas);
                break;
            case "6":
                Console.WriteLine("\nSaliendo del programa...");
                return;
            default:
                Console.WriteLine("\nOpción no válida. Por favor, intente nuevamente.");
                break;
        }
}

void InscribirEscuela(List<Escuela> escuelas)
{
    Console.Write("\nIngrese el nombre de la Escuela: ");
    string nombreEscuela = Console.ReadLine();

    Escuela escuela = new Escuela()
    {
        Nombre = nombreEscuela,
        cursos = new List<Curso>()
    };

    escuelas.Add(escuela);
    Console.WriteLine("\nEscuela inscribido exitosamente!");
}

void InscribirCurso(List<Escuela> escuela)
{
    if(escuelas.Count() == 0)
    {
        Console.WriteLine("\nNo se puede inscribir porque no existe una escuela.");
    }
    else
    {
        Console.Write("Ingrese el nombre de la escuela a inscribir el curso: ");
        string nombreEscuela = Console.ReadLine();

        if(escuelas.Any(escuela => escuela.Nombre == nombreEscuela))
        {

            Console.Write("Ingrese el codigo del curso: ");
            string codigo = Console.ReadLine();

            Console.Write("Ingrese el anio del curso: ");
            int anio = Convert.ToInt16(Console.ReadLine());

            Console.Write("Ingrese la division del curso: ");
            int division = Convert.ToInt16(Console.ReadLine());

            Console.Write("Ingrese el ciclo lectivo del curso: ");
            int ciclo_lectivo = Convert.ToInt16(Console.ReadLine());
            Curso curso = new Curso()
            {
                Codigo = codigo,
                Anio = anio,
                Division = division,
                Ciclo_lectivo = ciclo_lectivo,
                Alumnos = new List<Alumno>()
            };
            foreach(Escuela escuelaExistente in escuelas)
            {
                if(escuelaExistente.Nombre == nombreEscuela)
                {
                    escuelaExistente.cursos.Add(curso);
                }
            }
            Console.WriteLine("\nCurso inscribido exitosamente!");
        }
        else
        {
            Console.WriteLine("\nEscuela no existe.");
        }
    }
}

void InscribirAlumno(List<Escuela> escuelas, List<TipoDocumento> tipoDocumentos)
{
    if(escuelas.Count() == 0)
    {
        Console.WriteLine("\nNo se puede inscribir porque no existe una escuela.");
    }
    else if(escuelas.Any(escuela => escuela.cursos.Count() != 0))
    {
        Console.Write("Ingrese el nombre de la escuela a inscribir el curso: ");
        string nombreEscuela = Console.ReadLine();

        if(escuelas.Any(escuela => escuela.Nombre == nombreEscuela))
        {
            Console.Write("Ingrese el codigo del curso a inscribir el alumno: ");
            string codigo = Console.ReadLine();
            if(escuelas.Any(escuela => escuela.Nombre == nombreEscuela && escuela.cursos.Any(curso => curso.Codigo == codigo)))
            {
                Escuela  escuela = escuelas.FirstOrDefault(escuela => escuela.Nombre == nombreEscuela);
                Curso curso = escuela.cursos.FirstOrDefault(curso => curso.Codigo == codigo);

                Console.Write("Ingrese el nombre del alumno: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese el apellido del alumno: ");
                string apellido = Console.ReadLine();
                Console.Write("Ingrese el numero de documento del alumno: ");
                int numero_Documento = Convert.ToInt32(Console.ReadLine());
                while(true)
                {
                    Console.Write("Ingrese el tipo de documento del alumno: ");
                    string nombreTipoDocumento = Console.ReadLine();
                    if(tipoDocumentos.Any(tipoDocumento => tipoDocumento.Nombre == nombreTipoDocumento))
                    {   
                        Alumno alumno = new Alumno()
                        {
                            Nombre = nombre,
                            Apellido = apellido,
                            NumDocumento = numero_Documento,
                            TipoDocumento = tipoDocumentos.FirstOrDefault(tipoDocumento => tipoDocumento.Nombre == nombreTipoDocumento)
                        };
                        curso.Alumnos.Add(alumno);
                        Console.WriteLine("\nAlumno inscribido exitosamente!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nNo existe este tipo de documento.");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nCurso no existe.");
            }
        }
        else
        {
            Console.WriteLine("\nEscuela no existe.");
        }
    }
    else
    {
        Console.WriteLine("\nNo existe ninguna escuela con un curso.");
    }

}

void MostrarCursos(List<Escuela> escuelas)
{
    Console.Write("Ingrese le nombre de la escuela: ");
    string nombreEscuela = Console.ReadLine();

    if(escuelas.Any(escuela => escuela.Nombre == nombreEscuela))
    {
        Escuela escuela = escuelas.FirstOrDefault(escuela => escuela.Nombre == nombreEscuela);
        List<Curso> cursos = escuela.cursos;
        
        Console.WriteLine("\nCursos de la escuela: ");

        foreach(Curso curso in cursos)
        {
            Console.WriteLine($"Codigo: {curso.Codigo}, Anio: {curso.Anio}, Division: {curso.Division}");

        }
    }
    else
    {
        Console.WriteLine("\nEscuela no existe.");
    }
}

void MostrarAlumnos(List<Escuela> escuelas)
{
    Console.Write("Ingrese le nombre de la escuela: ");
    string nombreEscuela = Console.ReadLine();

    if(escuelas.Any(escuela => escuela.Nombre == nombreEscuela))
    {
        Escuela escuela = escuelas.FirstOrDefault(escuela => escuela.Nombre == nombreEscuela);

        Console.WriteLine("\nIngrese el codigo del curso a saber: ");
        string codigoCurso = Console.ReadLine();

        if(escuela.cursos.Any(curso => curso.Codigo == codigoCurso))
        {
            Curso curso = escuela.cursos.FirstOrDefault(curso => curso.Codigo == codigoCurso);
            foreach(Alumno alumno in curso.Alumnos)
            {
                Console.WriteLine($"Nombre: {alumno.Nombre}, Apellido: {alumno.Apellido}");

            }
        }
        else
        {
            Console.WriteLine("\nCurso no esiste.");
        }
    }
    else
    {
        Console.WriteLine("\nEscuela no existe.");
    }
};