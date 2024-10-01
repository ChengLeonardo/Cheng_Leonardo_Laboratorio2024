namespace Biblioteca;

public static class Verificacion
{
    public static void VerificarPositivo(double numero)
    {
        if(numero <= 0)
        {
            throw new Exception("Numero ingresado negativo");
        }
    }

    public static double IngresoDatoNoNegativoYNoString(string dato)
    {
        double datoPasadoDouble = 0;
        try
        {
            datoPasadoDouble = Convert.ToDouble(dato);
            VerificarPositivo(datoPasadoDouble);
        }
        catch(FormatException ex)
        {
            System.Console.WriteLine("Dato Ingresado INCORRECTO");
            datoPasadoDouble = 0;
        }
        catch(Exception ex)
        {
            System.Console.WriteLine(ex.Message);
            datoPasadoDouble = 0;
        }
        return datoPasadoDouble;
    }
}