namespace clases;
public static class Validacion
{
    public static void ValidacionStringEmptyOrNull(string palabra, string mensaje)
    {
        if(string.IsNullOrEmpty(palabra))
        {
            throw new Exception(mensaje);
        }
    }
    public static void ValidacionPrecio(float precio)
    {
        if(precio <= 0)
        {
            throw new Exception("Precio no puede ser negativo.");
        }
    }
    public static void ValidacionStock(int cantidad)
    {
        if(cantidad < 0)
        {
            throw new Exception("Stock no pude ser negativo. ");
        }
    }
}