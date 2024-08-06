using System.Data;
using System.Security.AccessControl;

namespace clasePersona;

public class Persona
{
    // Realizar una clase llamada Persona que posea los siguientes atributos: nombre, edad, peso (en kilogramos) y altura (en metros). 
    public string nombre;
    public int edad;
    public float peso;
    public float altura;
    // Parte 2
    // Realizar los cambios correspondientes para validar que los valores ingresados por el usuario. En caso de que el valor ingresado no se encuentre en el rango correcto se debe lanzar una excepción indicando cual es el error en cuestión.

    public string Nombre
    {
        get{return nombre;}
        set{
            if(value == "")
            {
                throw new Exception("no admite nulos.");
            }
            else
            {
                nombre = value;
            }
        }
    }
    public Persona()
    {
        Console.WriteLine("Ingrese el nombre de la persona: ");
        Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese la edad de la persona: ");
        edad = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingrese el peso de la persona(kg): ");
        peso = float.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la altura de la persona(mts): ");
        altura = float.Parse(Console.ReadLine());
    }
    // Los métodos que se implementarán en la clase Persona son:
    // calcularImc: determina el IMC (Índice de Masa Corporal) de la persona mediante la fórmula PESO (kg)/ALTURA * ALTURA (metros). El método debe retornar una leyenda con la situación de peso de la persona si el resultado es menor a 18.5, devuelve una cadena de caracteres con la leyenda “bajo peso”, si el resultado se encuentra con un valor entre 18.5 y 25 la persona se encuentra en su “peso ideal” y si el resultado es mayor a 25 la persona  tiene “sobrepeso”.
    public void CalcularImc()
    {
        float Imc = peso / (altura * altura);
        if (Imc < 18.5)
        {
            Console.WriteLine("bajo peso");
        }
        else if(Imc >= 18.5 && Imc <= 25)
        {
            Console.WriteLine("peso ideal.");
        }
        else
        {
            Console.WriteLine("sobre peso.");
        }
    }
    // esMayorEdad: indica si es mayor de edad (mayor o igual a 18 años), devuelve verdadero si es cierto, caso contrario falso.
    public bool EsMayorEdad()
    {
        bool mayor;
        if(edad >= 18)
        {
            mayor = true;
        }
        else
        {
            mayor = false;
        }
        return mayor;
    }
    // Informar: devuelve toda la información del objeto en formato de cadena en una sola línea.
    public void Informar(){
        Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Peso: {peso}, altura: {altura}");
    }
}


