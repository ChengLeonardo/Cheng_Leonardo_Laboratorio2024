namespace claseEmpleado;

public class Empleado 
{
    public string nombre;
    public string email;
    public decimal salario;

    public Empleado(string nombre, string email, decimal salario)
    {
        this.nombre = nombre;
        this.email = email;
        this.salario = salario;
    }
}