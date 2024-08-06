//Realizar un algoritmo que permita ingresar un número entero que represente un día de la semana (0:Domingo, 1:Lunes, 2:Martes, 3:Miércoles, 4:Jueves, 5:Viernes, 6:Sábado). Informar por pantalla si el valor ingresado representa un día hábil (Lunes a Viernes)l, fin de semana o no corresponde a un día de la semana.
/*
Console.WriteLine("Ingrese un dia de la semana (0:Domingo, 1:Lunes, 2:Martes, 3:Miércoles, 4:Jueves, 5:Viernes, 6:Sábado): ");
int dia = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(verificacionDia(dia));

string verificacionDia(int dia){
    if(dia == 1 || dia == 2 || dia == 3 || dia == 4 || dia == 5){
        return "dia habil";
    }
    else if(dia == 6 || dia == 0 ){
        return "fin de semana";
    }
    else{
        return "no corresponde a un dia de la semana";
    }
}
*/

/*Realizar un algoritmo que permita ingresar números enteros hasta que se ingrese el cero e informar por pantalla:
La suma de todos números positivos
La cantidad total de números ingresados 
int cantidad = 0;
int suma = 0;
bool paraPrograma = false;
while (paraPrograma == false){
    int numero = ingresoNumero();
    int verificacion = verificacionPositivo(numero);
    if (verificacion == 1){
        suma = suma + numero;
        cantidad ++;
    }
    else if(verificacion == 0){
        paraPrograma = true;
    }
}

int ingresoNumero(){
    Console.WriteLine("Ingrese un numero entero(para parar ingrese 0): ");
    int numero = Convert.ToInt16(Console.ReadLine());
    return numero;
}

int verificacionPositivo(int num){
    if (num > 0){
        return 1;
    }
    else if(num == 0){
        return 0;
    }
    else{
        return -1;
    }
}

Console.WriteLine("Cantidad de numeros ingresados: " + cantidad);
Console.WriteLine("Suma de numeros positivos: " + suma);
*/

//Realizar un algoritmo para mostrar por pantalla los números del 20 al 200 en orden creciente
/*
for (int i = 20; i<= 200 ; i++){
    Console.WriteLine(i);
}
*/
