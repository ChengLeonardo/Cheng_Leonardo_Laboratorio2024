namespace BilbiotecaClases;

public static class Verificacion
{
    public static void VerificarPositivo(double num)
    {
        if(num < 0)
        {
            throw new Exception("Es negativo");
        }
        else if (num == 0)
        {
            throw new Exception("Es neutro");
        }
    }
}