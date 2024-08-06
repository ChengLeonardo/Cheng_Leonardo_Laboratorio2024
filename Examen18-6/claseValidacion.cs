namespace claseValidacion;

public static class Validacion
{
    public static void ValidacionString(string cadena, string mensaje)
    {
        if(string.IsNullOrEmpty(cadena))
        {
            throw new Exception(mensaje);
        }

    }
    public static void ValidacionPositivo(int numero, string mensaje)
    {
        if(numero <= 0)
        {
            throw new Exception(mensaje);
        }
    }
}