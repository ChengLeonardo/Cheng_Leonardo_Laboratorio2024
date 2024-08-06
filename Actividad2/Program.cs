//Resolver con ciclo For

//Realizar un algoritmo que informe por pantalla todos los números enteros del 100 al 200.
/*
for (int i = 100; i <= 200; i++)
Console.WriteLine(i);
*/
//Realizar un algoritmo que informe por pantalla todos los números impares enteros del 1 al 1000.
/*
for (int i = 1; i <= 1000; i = i + 2)
Console.WriteLine(i);
*/
//Hacer un algoritmo para mostrar por pantalla los números del 1000 al 500 en orden decreciente.
/*for (int i = 1000; i >= 500; i--)
Console.WriteLine(i);
*/
//Escribir un programa que informe por pantalla los múltiplos de 7 y de 5 comprendidos entre 50 y 500.
/*
int i;
for (i = 50; i <= 500; i++){
    if (i % 7 == 0 && i % 5 == 0)
        Console.WriteLine(i + " es multiplo de 7 y de 5");
}
*/
//Resolver con ciclo While

//Realizar un algoritmo que informe por pantalla todos los números naturales desde el 1 (uno) hasta el número natural que el usuario ingrese por teclado.
/*
int numero = 0;
while(numero <= 0){
Console.WriteLine("Ingrese un numero natural");
numero = Convert.ToInt32(Console.ReadLine());
};
int i = 1;
while(i <= numero){
    Console.WriteLine(i);
    i++;
};
*/
//Hacer un algoritmo que permita al usuario ingresar un número entero y efectuar la suma de todos los números naturales desde 1 (uno) hasta el número ingreso. Informar el resultado de la suma por pantalla.
/*
Console.WriteLine("Ingrese un numero entero");
int numero = Convert.ToInt32(Console.ReadLine());
int i = 1;
int suma = 0;
while(i <= numero){
    suma = suma + i;
    Console.WriteLine(suma);
    i++;
};
*/
//Diseñar un algoritmo en el cual el usuario ingrese números indefinidamente. Si el número ingresado es cero se debe detener la carga e informar por pantalla la suma de los números positivos y el producto de los números negativos.
/*
decimal numero = 1;
decimal total = 0;
decimal totalnega = 0;
while(numero != 0){
Console.WriteLine("Ingrese un numero en el caso de que sea cero se para");
numero = Convert.ToDecimal(Console.ReadLine());
if (numero > 0)
total += numero;
if(numero < 0){
if (totalnega == 0)
totalnega = numero;
else
totalnega = totalnega * numero;
}}
Console.WriteLine("Suma de los numeros positivos: " + total);
Console.WriteLine("Producto de los numeros negativos: " + totalnega);
*/
//Realizar un algoritmo en donde el usuario ingrese cadenas de caracteres de forma indefinida. Si la cadena ingresada es una cadena vacía (salto de línea), se debe informar por pantalla la cantidad de líneas ingresadas.
/*
string cadena = "hola";
int counter = 0;
while(cadena != ""){
    Console.WriteLine("ingrese una cadena");
    cadena = Console.ReadLine();
    if (cadena != "")
    counter ++;
}
Console.WriteLine("Cantidad de lineas ingresadas: " + counter);
*/
//Resolver con ciclo Do-While

//Realizar un algoritmo en donde el usuario ingrese dos números enteros distintos indefinidamente. Se debe informar por pantalla la suma de dichos números siempre y cuando ambos números sean distintos. Si ambos números son iguales debe finalizar el algoritmo.
/*int entero1 = 0;
int entero2 = 0;
do{
    Console.WriteLine("Ingrese el primer numero entero:");
    entero1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el segun numero entero:");
    entero2 = Convert.ToInt32(Console.ReadLine());
    if(entero1 != entero2)
    Console.WriteLine(entero1 + entero2);
}while(entero1 != entero2);
*/
//Realizar un algoritmo que informe por pantalla todos los números naturales desde el 1 (uno) hasta el número natural que el usuario ingrese por teclado.
/*
int numero = 0;
int counter = 1;
do{
    Console.WriteLine("Ingrese un numero natural");
    numero = Convert.ToInt32(Console.ReadLine());
    if(numero > 0 ){
        do{
            Console.WriteLine(counter);
            counter++;
        }while(counter <= numero);
    };
}while(numero <= 0);
*/
//Hacer un algoritmo para mostrar por pantalla los números del 20 al 200 en orden creciente
/*int counter = 20;
do{
    Console.WriteLine(counter);
    counter++;
}while(counter <= 200);
*/

//Resolver

//Realizar un algoritmo que permita al usuario ingresar por teclado la cantidad de agua caída en milímetros (número entero) día a día durante un mes (1 mes = 30 días). Se pide informar por pantalla el número de día en el que llovió más, el número de día en el que llovió menos y el promedio de lluvia caída (en milímetros) durante el mes.
/*
int numero = 0;
int counter = 0;
int mayor = numero;
int menor = numero;
int mayordia = 1;
int menordia = 1;
decimal promedio = 0;
do{
    Console.WriteLine("Cantidad de agua");
    numero = Convert.ToInt32(Console.ReadLine());
    if(numero >= 0 ){
        counter++;
        if (counter == 1){
            mayor = numero;
            menor = numero;
        }
        if(mayor < numero){
        mayor = numero;
        mayordia = counter;
        };
        if (menor > numero){
        menordia = counter;
        menor = numero;
        };
        promedio += numero;
    }
    else
        Console.WriteLine("numero ingresado incorrecto");
}while (counter < 30);
promedio = promedio / 30;
Console.WriteLine("Numero de dia en el que llovio mas: " + mayordia + "Numero de dia en el que llovio menos: " + menordia + "Promedio de lluvia caida durante el mes: " + promedio);
*/
//Realizar un programa que pida la estatura (en metros) y edad de un número indeterminado de personas. Posteriormente se debe informar por pantalla la estatura media de las personas mayores a 21 años y la estatura más alta de las personas menores a 21 años.
/*
decimal estaturamedia = 0;
decimal estatura = 0;
int edad = 0;
decimal mayor = 0;
int counter = 0;
int counter2 = 0;
do{
    if (edad > 21 && edad != 0){
        estaturamedia += estatura;
        counter2++;
    }
    if (edad < 21 && edad != 0){
        if (counter == 0){
            mayor = estatura;
            counter ++;
        }
        else{
            if (mayor < estatura){
                mayor = estatura;
            };}
    }
    Console.WriteLine("Ingrese la estatura de la persona(para finalizar ingrese 0): ");
    estatura = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Ingrese la edad de la persona: (para finalizar ingrese 0)");
    edad = Convert.ToInt32(Console.ReadLine());
}while(estatura != 0 && edad != 0);
if (counter2 != 0){
    Console.WriteLine("Estatura media de las personas mayores a 21 años: " + (estaturamedia / counter2));
}
if(counter != 0)
    Console.WriteLine("Estatura mayor de las personas menores a 21 años: " + mayor);
*/
//Realizar un algoritmo que lea una cantidad indefinida de números naturales y se termine la carga con el número cero. Posteriormente informar por pantalla cuál fue el número mayor ingresado y que cantidad de veces fue ingresado.
/*
int counter = 0;
int counternum = 0;
int mayor = 0;
bool paraPrograma = false;
while(paraPrograma == false){
    Console.WriteLine("Ingrese un numero natural: ");
    int nnatural = Convert.ToInt32(Console.ReadLine());
    if (nnatural < 0){
        Console.WriteLine("Numero ingresado incorrecto");
    }
    else {
        if (nnatural == 0){
        paraPrograma = true;
        }
        else{
            counter++;
            if (counter == 1){
                mayor = nnatural;
                counternum++;
            }
            else{
                if (mayor == nnatural){
                    counternum++;
                }    
                if(mayor < nnatural){
                    mayor = nnatural;
                    counternum = 1;
                }

            }
        }
    }    
}
Console.WriteLine("Numero mayor ingresado: " + mayor + ", veces ingresado: " + counternum);
*/