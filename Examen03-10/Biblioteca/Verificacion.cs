namespace Biblioteca;

public static class Verificacion
{
    public static bool VerificarTipoNumero(string numero)
    {
        bool esNumero = false;
        try
        {
            Convert.ToDouble(numero.Replace('.', ','));
            esNumero = true;
        }
        catch
        {
            
        }
        return esNumero;
    }
    public static bool VerificarNumeroPositivo(double numero)
    {
        bool esPositivo = false;
        if(numero >= 0)
        {
            esPositivo = true;
            return esPositivo;
        }
        else
        {
            throw new Exception();
        }
    }
}