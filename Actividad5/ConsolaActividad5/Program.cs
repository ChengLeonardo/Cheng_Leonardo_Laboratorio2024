using BibliotecaActividad5;

Console.Write("Ingrese el nombre del Alumno: ");
string nombre = Console.ReadLine();
List<Curso> cursos = new List<Curso>();
List<Alumno> alumnos = new List<Alumno>();

while (nombre != "")
{
    Console.Write("Ingrese el apellido del alumno: ");
    string apellido = Console.ReadLine();
    
    Console.Write("Ingrese el numero de documento del alumno: ");
    int numero_Documento = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Ingrese el tipo de documento del alumno: ");
    string tipoDocumento = Console.ReadLine();
    Alumno alumno = new Alumno()
    {
        Nombre = nombre,
        Apellido = apellido,
        NumDocumento = numero_Documento,
        TipoDocumento = tipoDocumento
    };

    alumnos.Add(alumno);

    Console.Write("Si quiere parar el programa, no ingrese nada, si quiere seguir ingresar alumnos, ingrese el nombre del alumno, si quiere agregar los alumnos al curso, ingrese 'curso': ");
    nombre = Console.ReadLine();

    if(nombre == "curso")
    {
        while()
        {
            nombre = "";
            Console.Write("Ingrese el codigo del curso: ");
            string codigo = Console.ReadLine();

            Console.Write("Ingrese el anio del curso: ");
            int anio = Convert.ToInt16(Console.ReadLine());

            Console.Write("Ingrese la division del curso: ");
            int division = Convert.ToInt16(Console.ReadLine());

            Console.Write("Ingrese el ciclo lectivo del curso: ");
            int ciclo_lectivo = Convert.ToInt16(Console.ReadLine());

            List<Alumno> alumnosAgregar = new List<Alumno>();

            Console.Write("Ingrese el tipo de documento del alumno a agregar: ");
            tipoDocumento = Console.ReadLine();
            while(tipoDocumento != "")
            {
                Console.Write("Ingrese el numero de documento del alumno a agregar: ");
                numero_Documento = Convert.ToInt32(Console.ReadLine());

                bool existe = alumnos.Any(p => p.NumDocumento == numero_Documento && p.TipoDocumento == tipoDocumento);

                if(existe)
                {
                    alumnosAgregar.AddRange(alumnos.Where(p => p.NumDocumento == numero_Documento && p.TipoDocumento == tipoDocumento));
                } 
                else
                {
                    Console.WriteLine("alumno ingresado no existe.");
                }

                Console.Write("Ingrese el tipo de documento del alumno a agregar, si quiere parar el programa, no ingrese nada, si quiere ingresar nuevos alumnos, ingrese 'alumnos', si quiere ingresar otros cursos, ingrese 'curso', si quiere ingresar una escuela nueva, ingrese 'escuela': ");
                tipoDocumento = Console.ReadLine();
                if(tipoDocumento == "" && alumnosAgregar.Count() != 0)
                {
                    Curso curso = new Curso()
                    {
                        Codigo = codigo,
                        Anio = anio,
                        Division = division,
                        Ciclo_lectivo = ciclo_lectivo,
                        Alumnos = alumnosAgregar
                    };
                    cursos.Add(curso);
                }
            }
        }
    }
}
