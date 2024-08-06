namespace clases;
public class Tienda
{
    public string Nombre {get;}
    private List<Producto> productos = new List<Producto>();
    public Tienda(string nombre){
        Nombre = nombre;
    }

    public void AgregarProducto(Producto producto)
    {   
        productos.Add(producto);
    }

    public void EliminarProducto(string codigo)
    {
        var productoEliminar = productos.First(produc => produc.Codigo == codigo);
        productos.Remove(productoEliminar);
    }

    public Producto Buscar(bool nombre, string busqueda)
    {
        if(nombre == false)
        {
            var producto = productos.First(produc => produc.Codigo == busqueda);
            return producto;
        }

        else
        {
            var producto = productos.First(produc => produc.Nombre == busqueda);
            return producto;
        }
    }

    public List<Producto> Mostrar()
    {
        var lista = productos.OrderBy(produc => produc.Nombre).Select(produc => produc).ToList();
        return lista;
    }

    public Factura Venta(
        List<Item> lista, string comprador)
    {    
        Factura factura = new Factura(comprador){       
            items = lista
        };
        return factura;
    }
}