// Libro


namespace claseLibro;

public class Libro
{
    // En algún momento determinado se desea saber si el libro se encuentra abierto o cerrado, al momento de creación del libro este se encuentra cerrado.
    private bool cerrado = true;
    // Crear una clase Libro que contenga los siguientes atributos:
    // Título 
    // Autor 
    // Cantidad de páginas
    public string titulo;
    public string autor;
    public int cantidadPaginas;

    private bool AbrirCerrar
    {
        set
        {
            if(cerrado == true)
            {
                if(value == false)
                {
                    Console.WriteLine("Ya estaba cerrada.");
                }
                else
                {
                    cerrado = false;
                    Console.WriteLine("Ya esta abierta.");
                }
            }
            else
            {
                if(value == true)
                {
                    Console.WriteLine("Ya estaba abierta.");
                }
                else
                {
                    cerrado = true;
                    Console.WriteLine("Ya esta cerrada.");
                }
            }
        }
    }
    // El usuario debe poder ingresar mediante pantalla el título, autor y la cantidad de páginas del libro
    public Libro(string titulo, string autor, int cantidadPaginas)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.cantidadPaginas = cantidadPaginas;
    }
    // Realizar un método llamado Informar() para mostrar la siguiente información del libro por pantalla con el formato:
    public void Informar()
    {
        string estado;
        if(cerrado == false)
        {
            estado = "abierto";
        }
        else
        {
            estado = "cerrado";
        }
        // “El libro <su_titulo> escrito por <su_autor> tiene <cantidad_paginas> páginas, su estado es <estado_libro>”
        Console.WriteLine($"El libro {titulo} escrito por {autor} tiene {cantidadPaginas} paginas, su estado es {estado}");
    }
    // Realizar los métodos para abrir y cerrar el libro. Abrir el libro consiste en que el objeto libro debe tener un atributo que almacene dicho estado,. Tener en cuenta las siguientes situaciones al abrir y cerrar un libro, un libro no se puede abrir si se encuentra abierto ni cerrar si se encuentra cerrado, en caso contrario se debe informar por pantalla dicho inconveniente.

    public void Abrir()
    {
        AbrirCerrar = true;
    }

    public void Cerrar()
    {
        AbrirCerrar = false;
    }
}