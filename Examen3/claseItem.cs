namespace clases;
public class Item
{
    public string NombreProducto {get;}
    public float PrecioUnitario {get;}
    public int Cantidad{get;}
    public float Subtotal{get;}
    public Item(string nombre, float precio, int cantidad)
    {
        NombreProducto = nombre;
        PrecioUnitario = precio;
        Cantidad = cantidad;
        Subtotal = cantidad * precio;
    }
}