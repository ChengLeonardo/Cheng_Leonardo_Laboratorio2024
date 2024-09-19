using BilbiotecaClases;

while (true)
{
    try
    {
        Console.Write("Ingrese el lado del cuadrado:");
        double lado = double.Parse(Console.ReadLine());
        FiguraGeometrica cuadrado = new Cuadrado(lado);

        System.Console.WriteLine($"Superficie = {cuadrado.Superficie}, Perimetro = {cuadrado.Perimetro}");
        break;
    }
    catch
    {
        Console.WriteLine("El valor ingresado es incorrecto");
    }
}
while(true)
{
    try
    {
        Console.Write("Ingrese el radio del circulo:");
        double radio = double.Parse(Console.ReadLine());
        FiguraGeometrica circulo = new Circulo(radio);
        System.Console.WriteLine($"Superficie = {circulo.Superficie}, Perimetro = {circulo.Perimetro}");
        break;
    }
    catch
    {
        System.Console.WriteLine("Elvalor ingresado es incorrecto");
    }
}