// En el programa principal realizar la acción de abrir el libro, informar su estado, luego cerrar el libro e informar su estado nuevamente.
using claseLibro;

Libro libro1 = new("sdfa", "leonardo", 3);
libro1.Abrir();
libro1.Informar();
libro1.Cerrar();
libro1.Informar();