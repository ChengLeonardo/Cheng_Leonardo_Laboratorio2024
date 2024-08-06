// Netflix

using clasePeli;
using claseReproduccion;
using claseValidacion;
// Para la presentación de los listados por consola se tendrá en cuenta la utilización del paquete nuget ConsoleTables.
// dotnet add package ConsoleTables --version 2.6.1
using ConsoleTables;
// La aplicación debe permitir ingresar todos los datos mencionados por consola. El ingreso de datos debe detenerse cuando el nombre de la película sea una cadena vacía. Todos los datos ingresados deben ser validados, en el caso que algún dato sea incorrecto se debe lanzar una excepción indicando el error correspondiente y detener la aplicación.
Console.WriteLine("Ingrese el nombre de usuario: ");
string nombreUsuario = Console.ReadLine();
Validacion.ValidacionString(nombreUsuario, "no admite valores nulos en el nombre");

Console.WriteLine("Ingrese el nombre de la lista de reproduccion: ");
string nombreLista = Console.ReadLine();
Validacion.ValidacionString(nombreLista, "no admite valores nulos en el nombre de la lista");

ListaReproduccion listaReproduccion = new ListaReproduccion{
    NombreUsuario = nombreUsuario,
    Nombre = nombreLista};

Console.WriteLine("Ingrese el nombre de la pelicula para agregar en la lista de reproduccion(para parar el programa no ingrese nada)");
string nombrePeli = Console.ReadLine();


while(string.IsNullOrEmpty(nombrePeli) == false)
{
    Console.WriteLine("Ingrese el anyo de estreno de la pelicula: ");
    int anyo = Convert.ToInt16(Console.ReadLine());
    Validacion.ValidacionPositivo(anyo, "anyo no admite valores negativos o 0");

    Console.WriteLine("Ingrese la duracion de la pelicula: ");
    int duracion = Convert.ToInt16(Console.ReadLine());
    Validacion.ValidacionPositivo(duracion, "duracion no admite valores negativos o 0");
    
    Pelicula pelicula = new Pelicula{
        Nombre = nombrePeli,
        Anyo = anyo,
        Duracion = duracion
        };
    listaReproduccion.Peliculas.Add(pelicula);
    Console.WriteLine("Ingrese el nombre de la pelicula para agregar en la lista de reproduccion(para parar el programa no ingrese nada)");
    nombrePeli = Console.ReadLine();
}


// Al finalizar la carga de datos la aplicación debe mostrar por pantalla:
// Un listado de todas las películas (indicando solo el nombre) ordenadas alfabéticamente por nombre. 
var tabla = new ConsoleTable("Nombre Pelicula");
List<string> listaNombre = new List<string>();

foreach(Pelicula i in listaReproduccion.Peliculas)
{
    listaNombre.Add(i.Nombre); 
}
var listaOrdenada = listaNombre.OrderBy(nombre => nombre);

foreach(string x in listaOrdenada)
{
    tabla.AddRow(x);
}
tabla.Write();

// Un listado de todas las películas ordenadas en forma decrecientes por año de estreno (indicando todos los datos de cada película) cuya duración sea mayor a las 2hs.
var tablaPeli = new ConsoleTable("Nombre", "Anyo", "Duracion");
var listaOrdenadaAnyo = listaReproduccion.Peliculas.Where(Peli => Peli.Duracion > 120).OrderBy(Peli => Peli.Anyo);
foreach(Pelicula pelicula1 in listaOrdenadaAnyo)
{
    tablaPeli.AddRow(pelicula1.Nombre, pelicula1.Anyo, pelicula1.Duracion);
}
tablaPeli.Write();


