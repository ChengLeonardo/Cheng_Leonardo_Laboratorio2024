
/*
Ejercicio 1
Realizar un algoritmo que permita ingresar un número por teclado, validar mediante una función si el número es positivo, negativo o neutro, e informar por pantalla el resultado.

Console.WriteLine("Ingrese un numero: ");
int numero = Convert.ToInt16(Console.ReadLine());
string validacion = validarNumero(numero);
Console.WriteLine(validacion);

string validarNumero(int numeroAValidar){
    if (numeroAValidar > 0 ){
        return "numero positivo";
    }
    else if (numeroAValidar == 0 ){
        return "numero neutro";
    }
    else {
        return "numero negativo";
    }
}
*/

/*
Ejercicio 2
Realizar un algoritmo que permita al usuario ingresar 3 (tres) números e indicar cuántos son pares e impares (tener en cuenta que el número 0 (cero) es par). El proceso de validación debe realizarse mediante una función.

int cantidadPar = 0;

for (int i = 0; i < 3; i++){
    if (indicacionPar(ingresoNumero()) == "par"){
        cantidadPar++;
    }
}

Console.WriteLine("Cantidad de numeros pares: " + cantidadPar);
Console.WriteLine("Cantidad de numeros impares: " + (3 - cantidadPar));

int ingresoNumero(){
    Console.WriteLine("ingrese un numero");
    int numero = Convert.ToInt16(Console.ReadLine());
    return numero;
}

string indicacionPar(int numeroAValidar){
    if (numeroAValidar == 0 || numeroAValidar % 2 == 0){
        return "par";
    }
    else {
        return "impar";
    }
}
*/

/*
Ejercicio 3
Ingresa 3 (tres) números enteros y validar mediante una función si cada número se encuentra dentro del rango de -100 a 100. Se debe informar por pantalla el valor mínimo, el máximo y el promedio para aquellos números.

int minimo = 0;
int maximo = 0;
float promedio = 0;
for (int i = 0; i < 3; i++){
    int numero = ingresoNumero();
    bool indicacion = indicacionRango(numero);
    if (indicacion){
        Console.WriteLine("Numero ingresdado esta dentro del rango");
    }
    else{
        Console.WriteLine("Numero ingresado esta fuera del rango");
    }
    if (i == 0){
        minimo = numero;
        maximo = numero;
    }
    else {
        if (maximo < numero){
            maximo = numero;
        }
        if (minimo > numero){
            minimo = numero;
        }
    }
    promedio += numero;
}        

promedio = promedio / 3;
indicar("Valor minimo: ", minimo);
indicar("Valor maximo: ", maximo);
indicar("Valor promedio: ", promedio);

int ingresoNumero(){
    Console.WriteLine("ingrese un numero");
    int numero = Convert.ToInt16(Console.ReadLine());
    return numero;
}

bool indicacionRango(int numeroAValidar){
    if (numeroAValidar >= -100 && numeroAValidar <= 100){
        return true;
    }
    else {
        return false;
    }
}

void indicar(string mensaje, float variable){
    Console.WriteLine(mensaje + variable);
}
*/

/*
Ejercicio 4
Realizar un programa que se ingresen calificaciones (de 1 a 10) de forma indefinida y mediante una función escribir por pantalla la calificación en texto, por ejemplo si se ingresa 7 se debe informar “siete”. La carga debe finalizar cuando se ingresa la nota 0 (cero).

bool paraPrograma = false;

do{
    int numero = ingresoCalificaciones();
    string conversion = conversionATexto(numero);
    if (conversion != null){
        Console.WriteLine(conversion);
    }
    else{
        paraPrograma = true;
    }
}while(paraPrograma == false);

int ingresoCalificaciones(){
    Console.WriteLine("ingrese una calificacion(de 1 a 10): ");
    int numero = Convert.ToInt16(Console.ReadLine());
    return numero;
}

string conversionATexto(int numeroAConvertir){
    if(numeroAConvertir == 1){
        return "uno";
    }
    else if(numeroAConvertir == 2){
        return "dos";
    }
    else if(numeroAConvertir == 3){
        return "tres";
    }
    else if(numeroAConvertir == 4){
        return "cuatro";
    }
    else if(numeroAConvertir == 5){
        return "cinco";
    }
    else if(numeroAConvertir == 6){
        return "seis";
    }
    else if(numeroAConvertir == 7){
        return "siete";
    }
    else if(numeroAConvertir == 8){
        return "ocho";
    }
    else if(numeroAConvertir == 9){
        return "nueve";
    }
    else if(numeroAConvertir == 10){
        return "diez";
    }
    else{
        return null;
    }
}
*/

/*
Ejercicio 5
Crear una función que calcule la temperatura media de un día a partir de la temperatura máxima y mínima. Crear un programa principal, que utilizando la función anterior, vaya pidiendo la temperatura máxima y mínima de cada día y vaya informando por pantalla la temperatura media. El programa pedirá previamente el número de días que se van a introducir.

Console.WriteLine("Numero de dias: ");
int dias = Convert.ToInt16(Console.ReadLine());

for (int i = 0; i < dias; i++){
    Console.WriteLine("Temperatura maxima: ");
    decimal maximo = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Temperatura minima: ");
    decimal minimo = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Temperatura promedia del dia: " + calculaTemperaturaMedia(minimo, maximo));
}

decimal calculaTemperaturaMedia(decimal minimo, decimal maximo){
    decimal promedio = (minimo + maximo) / 2;
    return promedio;
}
*/


/*
Ejercicio 6 
Escribir un programa que permita ingresar una fecha compuesta por el campo día, mes y año (variables enteras). Validar mediante una función el día teniendo en cuenta si el año es bisiesto. Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400 (2000 es bisiesto pero 1900 no).  Informar por pantalla si el año es bisiesto o no.
Console.WriteLine("ingrese el año: ");
int year = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("ingrese el dia: ");
int day = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("ingrese el mes: ");
int month = Convert.ToInt16(Console.ReadLine());
bool bisiesto = validarBisiesto(year);

if (validarFecha(day, month, bisiesto) == true){
    if(bisiesto){
        Console.WriteLine("Es Bisiesto");
    }
    else{
        Console.WriteLine("No es Bisiesto");
    }
}
else{
    Console.WriteLine("Fecha ingresada incorrecta");
}

bool validarBisiesto(int year){
    if (year % 4 == 0){
        if (year % 100 == 0){
            if (year % 400 == 0){
                return true;
            }
            else{
                return false;
            }
        }
        else{
            return true;
        }
    }
    else{
        return false;
    }
}

bool validarFecha(int day, int month, bool bisiesto){
    if (day < 0 || month < 0 || day > 31 || month > 12){
        return false;
    }
    else if (day == 31){
        if(month == 1 && month == 3 && month == 5 && month == 7 && month == 8 && month == 10 && month == 12){
            return true;
        }
        else{
            return false;
        }
    }
    else if (day == 30){
        if (month == 2){
            return false;
        }
        else{
            return true;
        }
    }
    else if (day == 29){
        if (month == 2){
            if (bisiesto){
                return true;
            }
            else{
                return false;
            }
        }
        else{
            return true;
        }
    }
    else{
        return true;
    }
}
*/

/*
Ejercicio 7
Escribir un programa que permita ingresar una fecha compuesta por el campo día, mes y año. Validar mediante una función si la cantidad de días corresponde a cada mes del año, por ejemplo enero tiene 31 días. Imprimir por pantalla si la cantidad de días es correcta para el mes ingresado.

Console.WriteLine("ingrese el año: ");
int year = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("ingrese el dia: ");
int day = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("ingrese el mes: ");
int month = Convert.ToInt16(Console.ReadLine());
bool bisiesto = validarBisiesto(year);

if (validarFecha(day, month, bisiesto) == true){
    Console.WriteLine("Fecha ingresada correcta");
}

else{
    Console.WriteLine("Fecha ingresada incorrecta");
}

bool validarBisiesto(int year){
    if (year % 4 == 0){
        if (year % 100 == 0){
            if (year % 400 == 0){
                return true;
            }
            else{
                return false;
            }
        }
        else{
            return true;
        }
    }
    else{
        return false;
    }
}

bool validarFecha(int day, int month, bool bisiesto){
    if (day < 0 || month < 0 || day > 31 || month > 12){
        return false;
    }
    else if (day == 31){
        if(month == 1 && month == 3 && month == 5 && month == 7 && month == 8 && month == 10 && month == 12){
            return true;
        }
        else{
            return false;
        }
    }
    else if (day == 30){
        if (month == 2){
            return false;
        }
        else{
            return true;
        }
    }
    else if (day == 29){
        if (month == 2){
            if (bisiesto){
                return true;
            }
            else{
                return false;
            }
        }
        else{
            return true;
        }
    }
    else{
        return true;
    }
}
*/

/*
Ejercicio 8
Realizar un programa que permita el ingreso de varios valores que correspondan a la temperatura promedio de cada uno de los meses de un año. Mediante una función informar por pantalla si la temperatura es cálida (mayor o igual a 23°) o frío (menor o igual a 18°), en otro caso no se debe informar (temperatura templada).

for (int i = 1; i <= 12; i++){
    int validacion = validacionCalida(ingresoTemperatura(i));
    if(validacion == 1){
        Console.WriteLine("Es calida.");
    }
    else if(validacion == -1){
        Console.WriteLine("Es fria.");
    }
}

decimal ingresoTemperatura(int mes){
    Console.WriteLine("ingrese la temperatura del mes " + mes);
    decimal numero = Convert.ToDecimal(Console.ReadLine());
    return numero;
}

int validacionCalida(decimal temperaturaMediaMes){
    if (temperaturaMediaMes >= 23){
        return 1;
    }
    else if(temperaturaMediaMes <= 18){
        return -1;
    }
    else{
        return 0;
    }
}
*/
