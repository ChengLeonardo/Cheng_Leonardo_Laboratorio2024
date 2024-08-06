// Se pide realizar un programa que permita:
// Ingresar por pantalla el nombre, la edad, peso y altura de la persona.
// Instanciar un objeto de la clase Persona cuyo valores de los atributos serán los leídos por pantalla.
// Informar por pantalla el estado de peso de la persona.
// Informar si la persona es mayor de edad.
// Informar la información personal de la persona.
using clasePersona;

Persona persona1 = new();
persona1.CalcularImc();
if(persona1.EsMayorEdad())
{
    Console.WriteLine("Es mayor de edad.");
}
else
{
    Console.WriteLine("No es mayor de edad.");
}
persona1.Informar();
