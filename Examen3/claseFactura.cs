using System.Linq.Expressions;

namespace clases;
public class Factura
{
    public static int IdFactura{get;set;}
    public string Comprador{get;}

    public required List<Item> items = new List<Item>();

    public Factura(string comprador)
    {
        IdFactura++;
        Validacion.ValidacionStringEmptyOrNull(comprador, "El nombre del comprador no puede ser nulo o vacio.");
        Comprador = comprador;
    }

    public List<Item> Mostrar()
    {
        return items;
    }
}