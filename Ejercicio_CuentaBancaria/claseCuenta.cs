

namespace claseCuenta;
// El banco Santander Río ofrece muchos servicios, uno de ellos es la apertura de una cuenta bancaria gratuita para aquellas personas que sean clientes del mismo.

public class Cuenta
{
    // Cada cuenta bancaria posee un número de cuenta, un número de cliente titular de la cuenta, la moneda de la cuenta y el saldo actual.
    private int numeroCuenta;
    private int numeroClienteTitular;
    private string monedaCuenta;
    private float saldoActual = 0;

    private float SaldoActual
    {
        get{return saldoActual;}
        set
        {
            while(value < 0)
            {
                Console.WriteLine("Saldo cuenta incorrecto.");
                Console.WriteLine("Ingrese de vuelta: ");
                value = float.Parse(Console.ReadLine());
            }
            saldoActual = value ;
        }
    }
    public Cuenta()
    {   
        Console.WriteLine("Ingrese el numero de Cuenta: ");
        numeroCuenta = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingrese el numero de Cliente Titular: ");
        numeroClienteTitular = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Ingrese la moneda de Cuenta: ");
        monedaCuenta = Console.ReadLine();
        Console.WriteLine("Ingrese el saldo actual: ");
        SaldoActual = float.Parse(Console.ReadLine());
    }

    // Las posibles operaciones que se pueden realizar titular de la cuenta son:

    // depositar dinero el cual consiste en ingresar una cantidad a la cuenta, el nuevo saldo de la cuenta será el actual más la cantidad a depositar.
    public void DepositarDinero()
    {   
        Console.WriteLine("Ingrese le dinero a ingresar: ");
        float cantidadIngreso = float.Parse(Console.ReadLine()); 
        saldoActual += cantidadIngreso;
    }
    // retirar dinero el cual consiste en retirar una cantidad de dinero de la cuenta bancaria siempre y cuando se cuente con los fondos suficientes. En caso de no tener fondos suficientes informar por pantalla “La cuenta no posee fondos suficientes para realizar la operación.”
    public float RetirarDinero()
    {
        Console.WriteLine("Ingrese le dinero a retirar: ");
        float cantidadRetirar = float.Parse(Console.ReadLine());
        if(cantidadRetirar > saldoActual)
        {
            Console.WriteLine("La cuenta no posee fondos suficientes para realizar la operacion.");
            return 0;
        }
        else
        {
            saldoActual -= cantidadRetirar;
            return cantidadRetirar;
        }
    }
    // informar cuenta la cual consiste en informar todos los datos de la cuenta
    public void Informar()
    {
        Console.WriteLine("Numero de cuenta: " + numeroCuenta);
        Console.WriteLine("Numero de cliente titular: " + numeroClienteTitular);
        Console.WriteLine("Moneda de Cuenta: " + monedaCuenta);
        Console.WriteLine("Saldo Acutal: " + SaldoActual);
    }
}