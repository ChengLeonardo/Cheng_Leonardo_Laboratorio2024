// Realizar una aplicación que permita modelar una lista de reproducción de películas en la plataforma de Netflix. La lista de reproducción se tiene que poder identificar mediante un nombre, el nombre del usuario que la creó y un listado de películas de peliculas asociadas.

namespace claseReproduccion;

public class ListaReproduccion
{
    public string Nombre;
    public string NombreUsuario;
    public List<Pelicula> Peliculas = new List<Pelicula>();


}