namespace Biblioteca;

public class Persona
{
    private double peso { get; set; }
    private double altura { get; set; }
    private double IMC { get; set; }
    private string OMS { get; set; }
    public Persona(string peso, string altura)
    {
        
        this.altura = ConvertirDouble(altura);
        this.peso = ConvertirDouble(peso);
        IMC = CalcularIMC();
        OMS = ClasificarOMS();
    }

    private double CalcularIMC()
    {
        double IMC = peso / (altura * altura); 
        return IMC;
    }

    private string ClasificarOMS()
    {
        if(IMC < 18.5d)
        {
            return "Bajo Peso";
        }
        else if(IMC < 25.0d)
        {
            return "Adecuado";
        }
        else
        {
            return "Sobrepeso";
        }
    }
    private double ConvertirDouble(string dato)
    {
        double peso = Verificacion.IngresoDatoNoNegativoYNoString(dato);
        if(peso == 0)
        {
            throw new Exception();
        }
        return peso;
    }
    public void Informar()
    {
        System.Console.WriteLine("IMC de la persona ingresada:" + IMC);
        System.Console.WriteLine("OMS de la persona ingresado:" + OMS);
    }
}
