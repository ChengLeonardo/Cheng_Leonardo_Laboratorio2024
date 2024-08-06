// Guia 1

/*Ejercicio 1
Realizar un algoritmo que permita ingresar un número por teclado y nos informe si es positivo o negativo o neutro.
*/
Console.WriteLine("Escriba un numero");
decimal numero1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine(numero1 == 0 ? "Es un numero neutro" : (numero1 > 0 ? "Es un  numero positivo" : "Es un numero negativo"));

/*Ejercicio 2
Realizar un algoritmo en el cual se introduzca un número entero por teclado y nos informe si es par o impar o neutro.
*/
Console.WriteLine("Escriba un numero entero");
int numero2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numero2 == 0 ? "Es un numero neutro" : (numero2 % 2 == 0 ?  "Es un  numero par" : "Es un numero impar"));
/*Ejercicio 3
Realizar un programa en el que se ingrese 2 (dos) números enteros y se imprima por pantalla si cada número ingresado es par y positivo.
*/
Console.WriteLine("Escriba un numero entero");
int numero3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba otro numero entero");
int numero4 = Convert.ToInt32(Console.ReadLine());
if (numero3 % 2 == 0 && numero3 > 0)
    Console.WriteLine(numero3 + "Es un numero par y positivo");
if (numero4 % 2 == 0 && numero4 > 0)
    Console.WriteLine(numero4 + "Es un numero par y positivo");
/*Ejercicio 4
Realizar un algoritmo que permita al usuario ingresar un número entero positivo menor o igual a 10, caso contrario se debe informar por pantalla “Número ingresado incorrecto”.
*/
Console.WriteLine("Escriba un numero entero");
int numero5 = Convert.ToInt32(Console.ReadLine());
if (numero5 > 0)
{
    if(numero5 > 10 )
        Console.WriteLine("Numero ingresado incorrecto");
}
else
        Console.WriteLine("Numero ingresado incorrecto");
/*Ejercicio 5
Realizar un algoritmo que permita al usuario ingresar 3 (tres) números e indicar cuántos son positivos y negativos.
*/
Console.WriteLine("Escriba un numero");
decimal numero6 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
decimal numero7 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
decimal numero8 = Convert.ToDecimal(Console.ReadLine());
int contador = 0;
int contadornega = 0;
if (numero6 > 0)
    contador += 1;
if (numero6 < 0)
    contadornega += 1;
if (numero7 > 0)
    contador += 1;
if (numero7 < 0)
    contadornega += 1;
if (numero8 > 0)
    contador += 1;
if (numero8 < 0)
    contadornega += 1;
Console.WriteLine(contador + " numeros son positivos");
Console.WriteLine(contadornega + " numeros son negativos");
/*Ejercicio 6 
Realizar un algoritmo que permita al usuario ingresar 3 (tres) números e indicar cuántos son pares e impares (tener en cuenta que el número 0 (cero) es par).
*/
Console.WriteLine("Escriba un numero");
decimal numero9 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
decimal numero10 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
decimal numero11 = Convert.ToDecimal(Console.ReadLine());
int contadorpar = 0;
int contadorim = 0;
if (numero9 % 2 == 0)
    contadorpar ++;
else
    contadorim ++;
if (numero10 % 2 == 0)
    contadorpar ++;
else
    contadorim ++;
if (numero11 % 2 == 0)
    contadorpar ++;
else
    contadorim ++;
Console.WriteLine(contadorpar + " numeros son pares");
Console.WriteLine(contadorim + " numeros son impares");

/*Ejercicio 7
Realizar un algoritmo que permita al usuario ingresar 5 (cinco) números enteros e indicar cuántos de los números ingresados se encuentran en el rango de 100 a 500.
*/
Console.WriteLine("Escriba un numero entero");
int numero12 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba otro numero entero");
int numero13 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba un numero entero");
int numero14 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba otro numero entero");
int numero15 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba un numero entero");
int numero16 = Convert.ToInt32(Console.ReadLine());
int conta = 0;
if (numero12 < 500 && numero12 > 100)
    conta ++;
if (numero13 < 500 && numero13 > 100)
    conta ++;
if (numero14 < 500 && numero14 > 100)
    conta ++;
if (numero15 < 500 && numero15 > 100)
    conta ++;
if (numero16 < 500 && numero16 > 100)
    conta ++;
Console.WriteLine(conta + " numeros estan dentro del rango 100 y 500");
/*Ejercicio 8
Escribir un algoritmo que permita leer 3 (tres) números. Si el tercer número ingresado es positivo mostrar la suma de los tres números ingresados, si es negativo visualizar su producto.
*/
Console.WriteLine("Escriba un numero");
decimal numero17 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
decimal numero18 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
decimal numero19 = Convert.ToDecimal(Console.ReadLine());
decimal sumatoria = numero17 + numero18 + numero19;
decimal producto = numero17 * numero18 * numero19;
if (numero19 > 0)
    Console.WriteLine("Suma de los tres numeros: " + sumatoria);
if (numero19 < 0)
    Console.WriteLine("Producto de los tres numeros: " + producto);
/*Ejercicio 9
Escribir un algoritmo que permita ingresar al usuario una serie de 5 (cinco) números e informe por pantalla el número mayor y el número menor de total de los números ingresados.
*/
Console.WriteLine("Escriba un numero");
decimal numero20 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
decimal numero21 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
decimal numero22 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escriba un numero");
decimal numero23 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Escriba otro numero");
decimal numero24 = Convert.ToDecimal(Console.ReadLine());
decimal mayor = numero20;
decimal menor = numero20;
if (mayor < numero21)
    mayor = numero21;
if (mayor < numero22)
    mayor = numero22;
if (mayor < numero23)
    mayor = numero23;
if (mayor < numero24)
    mayor = numero24;
if (menor > numero21)
    menor = numero21;
if (menor > numero22)
    menor = numero22;
if (menor > numero23)
    menor = numero23;
if (menor > numero24)
    menor = numero24;
Console.WriteLine(mayor + " es el numero mayor, " + menor + " es el numero menor.");
/*Ejercicio 10
Realizar un algoritmo en donde se ingrese 4 (cuatro) números enteros y se determine en base a dichos valores si entre ellos se forma un cuadrado. Cada número representa un lado del cuadrado.
*/
Console.WriteLine("Escriba un numero entero");
int numero25 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba otro numero entero");
int numero26 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba un numero entero");
int numero27 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Escriba otro numero entero");
int numero28 = Convert.ToInt32(Console.ReadLine());
if (numero25 != 0 && numero25 > 0 && numero25 == numero26 && numero26 == numero27 && numero27 == numero28 )
    Console.WriteLine("Pueden formar un cuadrado");
else
    Console.WriteLine("No forman un cuadrado");
