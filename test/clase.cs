namespace claseReproduccion;
public class Estudiante
{
    public int Nota
    {
        get {};
        set
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Nota debe estar entre 0 y 100.");
            }
            // Esta línea asigna el valor a un campo generado automáticamente por el compilador.
            field = value;
        }
    }

    public string Nombre { get; set; }
}
