
// Ejercicio 1
// Escribir un programa en donde el usuario ingrese asignaturas de un curso (por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista y la informe por pantalla en orden alfabético.
// bool paraPrograma = false;
// List<string> asignaturas = new List<string>();
// while(paraPrograma == false)
// {
//     Console.WriteLine("ingrese la asignatura del curso, para parar el programa, no ingrese nada: ");
//     string asignatura = Console.ReadLine();
//     if(asignatura == "")
//     {
//         paraPrograma = true;
//     }
//     else
//     {
//         asignaturas.Add(asignatura);
//     }
// }

// foreach (string asig in asignaturas)
// {
//     Console.WriteLine(asig);
// };

// Ejercicio 2
// Escribir un programa que almacene las asignaturas de un curso (por ejemplo Matemáticas, Física, Química, Historia y Lengua) en una lista y su calificación asociada. Informar por pantalla las asignaturas con sus respectivas notas todo ordenado de forma descendente por nota.
// using claseCalificacion;
// bool paraPrograma = false;
// List<Calificacion> asignaturas = new List<Calificacion>();

// while(paraPrograma == false)
// {
//     Console.WriteLine("ingrese la asignatura del curso, para parar el programa, no ingrese nada: ");
//     string asignatura = Console.ReadLine();
//     if(asignatura == "")
//     {
//         paraPrograma = true;
//     }
//     else
//     {

//         Console.WriteLine("ingrese la clasificacion de la asignatura");
//         int calificacion = Convert.ToInt16(Console.ReadLine());
//         Calificacion calificacion1 = new(asignatura, calificacion);
//         asignaturas.Add(calificacion1);
//     }
// }

// foreach (Calificacion asig in asignaturas)
// {   
//     Console.WriteLine($"asignatura: {asig.asignatura}, calificacion: {asig.calificacion}");
// };


// Ejercicio 3
// Escribir un programa que se ingrese el nombre, email y salario de empleados en una fábrica. Informar por pantalla el nombre del empleado con mayor salario y el listado de empleados con todos sus datos ordenado alfabéticamente por nombre de empleado.
// using claseEmpleado;
// List<Empleado> empleados = new List<Empleado>();
// Console.WriteLine("Ingrese el nombre del empleado: ");
// string nombre = Console.ReadLine();
// while(nombre != "")
// {
//     Console.WriteLine("Ingrese el email del empleado: ");
//     string email = Console.ReadLine();
//     Console.WriteLine("Ingrese el salario del empleado: ");
//     decimal salario = Convert.ToDecimal(Console.ReadLine());
//     Empleado empleado = new(nombre, email, salario);
//     empleados.Add(empleado);
//     Console.WriteLine("Ingrese el nombre del empleado: ");
//     nombre = Console.ReadLine();
// }

// var empleadosOrdenados = empleados.OrderBy(empleado => empleado.nombre);

// string empleadoMayorSalario = "";
// decimal mayorSaldo = 0;
// foreach(Empleado empleado in empleadosOrdenados)
// {
//     Console.WriteLine($"Nombre: {empleado.nombre}, email: {empleado.email}, salario: {empleado.salario}.");
//     if(mayorSaldo < empleado.salario)
//     {
//         mayorSaldo = empleado.salario;
//         empleadoMayorSalario = empleado.nombre;
//     }

// }
// Console.WriteLine($"El empleado que tiene mayor saldo se llama: {empleadoMayorSalario}");

// Ejercicio 4
// Realizar un programa que permita al usuario ingresar por teclado la cantidad de agua caída en milímetros (número entero) día a día durante un mes (1 mes = 30 días). Se pide informar por pantalla el número de día en el que llovió más, el número de día en el que llovió menos y el promedio de lluvia caída (en milímetros) durante el mes
// using claseCantidadAguaDia;

// List <CantidadAguaDia> cantidadAguaDias = new();
// float promedio = 0;
// int mayor = 0;
// int menor = 0;
// int numeroDiaMayor = 0;
// int numeroDiaMenor = 0;
// for(int i = 1; i <= 30; i++)
// {
//     Console.WriteLine("Ingrese la cantidad de agua caida del dia(en milimetros): ");
//     int caidaAgua = Convert.ToInt32(Console.ReadLine());
//     CantidadAguaDia cantidadAguaDia = new(caidaAgua, i);
//     cantidadAguaDias.Add(cantidadAguaDia);
// }

// foreach(CantidadAguaDia cantidadAguaDia in cantidadAguaDias)
// {
//     if(cantidadAguaDia.caidaAgua > mayor)
//     {
//         mayor = cantidadAguaDia.caidaAgua;
//         numeroDiaMayor = cantidadAguaDia.dia;
//     }
//     if(cantidadAguaDia == cantidadAguaDias[0])
//     {
//         menor = cantidadAguaDia.caidaAgua;
//         numeroDiaMenor = cantidadAguaDia.dia;
//     }
//     else
//     {
//         if(menor > cantidadAguaDia.caidaAgua)
//         {
//             menor = cantidadAguaDia.caidaAgua;
//         }
//     }
//     promedio += cantidadAguaDia.caidaAgua;
// }

// Console.WriteLine($"numero de dia que llovio mas: {numeroDiaMayor}, numero de dia que llovio menos: {numeroDiaMenor}, promedio de la caida de agua: {promedio / 30}");

// Ejercicio 5
// Realizar un programa que pida la estatura (en metros) y edad de un número indeterminado de personas. Posteriormente se debe informar por pantalla la estatura media de las personas mayores a 21 años y la estatura más alta de las personas menores a 21 año
//  using clasePersona;
//  List<Persona> personas = new();
//  Console.WriteLine("ingrese el nombre de la persona: ");
//  string nombre = Console.ReadLine();
//  while(nombre != "")
//  {
//      Console.WriteLine("ingrese la altura de la persona: ");
//      float altura = float.Parse(Console.ReadLine());
//      Console.WriteLine("ingrese la edad de la persona: ");
//      int edad = Convert.ToInt16(Console.ReadLine());
//      Persona persona = new(nombre, altura, edad);
//      Console.WriteLine("ingrese el nombre de la persona: ");
//      nombre = Console.ReadLine();

//  var promedioEstaturaPersona = personas.Where(p => p.edad > 21).ToList().Average(p => p.altura);
//  var masAltaPersona = personas.Where(p => p.edad < 21).Max(p => p.altura)
//  Console.WriteLine($"Estatura media de las personas mayores a 21 anyos: {promedioEstaturaPersona}, estatura mas alta de las personas menores a 21 anyos: {masAltaPersona}");
//  }
// Ejercicio 6
// Realizar un algoritmo que lea una cantidad indefinida de números naturales y se termine la carga con el número cero. Posteriormente informar por pantalla cuál fue el número mayor ingresado y que cantidad de veces fue ingresado

// List<int> numero_naturales = new List<int>();
// Console.WriteLine("ingrese un numero natural(para parar el programa, ingrese 0): ");
// int numero_natural = Convert.ToInt16(Console.ReadLine());
// while(numero_natural != 0)
// {
//     if(numero_natural < 0)
//     {
//         while(numero_natural < 0)
//         {
//             Console.WriteLine("numero natural no admite negativos" +
//             "ingrese otro numero");
//             numero_natural = Convert.ToInt16(Console.ReadLine());
//         }
//         if(numero_natural != 0)
//         {
//             numero_naturales.Add(numero_natural);
//         }
//     }
//     else
//     {
//         numero_naturales.Add(numero_natural);
//     }
//     if(numero_natural != 0)
//     {
//         Console.WriteLine("ingrese otro numero: ");
//         numero_natural = Convert.ToInt16(Console.ReadLine());
//     }
// }

// int numero_natural_mayor = numero_naturales.Max();
// int veces_numero_natural_mayor = 0;
// foreach(int numero in numero_naturales)
// {
//     if(numero == numero_natural_mayor)
//     {
//         veces_numero_natural_mayor ++;
//     }
// }


// Console.WriteLine($"Numero mayor ingresado: {numero_natural_mayor}, cantidad de veces que fue ingresado: {veces_numero_natural_mayor}.");

// Ejercicio 7
// Realizar un programa en donde se generen 100 números enteros aleatorios (entre 1000 y 5000). Y se informe por pantalla cuántos de ellos son pares y cuántos son impares.

// List<int> enteros = new List<int>();
// Random random = new Random();
// for(int i = 0; i < 10; i++)
// {
//     int num_random = random.Next(1000, 5001);
//     enteros.Add(num_random);
// }

// var cantidad_par = enteros.Where(p => p % 2 == 0).Count();
// var cantidad_impar = enteros.Where(p => p % 2 != 0).Count();
// int cantidad_par = 0;
// int cantidad_impar = 0;

// foreach(int x in enteros)
// {
//     if(x % 2 == 0)
//     {
//         cantidad_par++;
//     }
//     if(x % 2 != 0)
//     {
//         cantidad_impar++;
//     }
// }
// Console.WriteLine($"Cantidad de numeros pares:{cantidad_par}, cantidad de numeros impares:{cantidad_impar}");

// Ejercicio 8
// Realizar un programa en donde se generen 100 números aleatorios de coma flotante (1000 y 2000). Y se informe por pantalla cuántos de ellos son mayores a 1700) y cual es el promedio de todos los números generados.

// List<double> flotante = new List<double>();
// Random random = new Random();
// double min = 1000.0;
// double max = 2000.0;

// for(int i = 0; i < 10; i++)
// {
//     double num_random = min + (random.NextDouble() * (max - min));
//     flotante.Add(num_random);
// }

// var cantidad_mayor_1700 = flotante.Where(p => p > 1700).Count();
// var promedio = flotante.Average();
// int cantidad_mayor_1700 = 0;
// double sumatoria = 0;
// double promedio = 0;
// foreach(double x in flotante)
// {
//     if(x > 1700)
//     {
//         cantidad_mayor_1700++;
//     }
//     sumatoria += x;
// }
// promedio = sumatoria / flotante.Count();
// Console.WriteLine($"Promedio:{promedio}, cantidad de numeros mayores a 1700: {cantidad_mayor_1700}.");
