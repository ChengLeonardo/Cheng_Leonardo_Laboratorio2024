// Se pide:

// Realizar un programa que represente la situación planteada y permita crear una nueva cuenta bancaria, por ejemplo realizar un depósito de dinero de $100 y un retiro de dinero de $200 de la misma cuenta.
// Luego de realizar cada operación se debe informar el estado de la cuenta por pantalla.
// Los siguiente datos se deben ingresar por consola/pantalla:
// número de cuenta
// número de cliente
// moneda de la cuenta
// saldo actual, se debe validar que el saldo no sea negativo caso contrario se debe visualizar un mensaje por pantalla “Saldo cuenta incorrecto” y se debe terminar la ejecución del programa.
// La cantidad de dinero a retirar y depositar se debe ingresar por consola/pantalla.
using claseCuenta;

Cuenta cuenta1 = new();
cuenta1.DepositarDinero();
cuenta1.Informar();
cuenta1.RetirarDinero();
cuenta1.Informar();
