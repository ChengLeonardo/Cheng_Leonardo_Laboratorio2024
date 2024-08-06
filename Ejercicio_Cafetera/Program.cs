// Cafetera

// Se pide:

// Realizar un programa en que represente la situación planteada
// Se debe poder ingresar por pantalla la capacidad actual de la cafetera, validando su valor
// En el programa principal ejecutar los métodos en el siguiente orden:
// hacer()
// servir()
// informar()
// vaciar()
// informar()

using claseCafetera;


Console.Write("Ingrese Nro Cuenta: ");
int nroCuenta = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese Nro Cliente: ");
int nroCliente = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese Moneda: ");
string moneda = Console.ReadLine();

Console.Write("Ingrese Saldo: ");
decimal saldo = Convert.ToDecimal(Console.ReadLine());

CuentaBancaria cuenta = new CuentaBancaria(nroCliente, nroCuenta, moneda, saldo);
Console.WriteLine("ingrese valor a depositar: ");

int deposita = Convert.ToInt32(Console.ReadLine());
cuenta.Depositar(deposita);
cuenta.Informar();
Console.WriteLine("ingrese valor a retirar: ");
int retira = Convert.ToInt32(Console.ReadLine());
cuenta.Retirar(retira);
cuenta.Informar();