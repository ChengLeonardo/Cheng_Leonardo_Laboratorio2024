using ConsoleTables;
using clases;

Console.Write("Ingrese el nombre de la tienda: ");
string nombreTienda = Console.ReadLine();
Validacion.ValidacionStringEmptyOrNull(nombreTienda, "El nombre de la tienda no puede ser nulo o vacio.");
Tienda tienda1 = new Tienda(nombreTienda);

Console.Write("Ingrese el nombre del producto(para parar el ingreso, no ingrese nada): ");
string nombre = Console.ReadLine();

while(nombre != "")
{
    Console.Write("Ingrese el codigo del producto: ");
    string codigo = Console.ReadLine();
    Validacion.ValidacionStringEmptyOrNull(codigo, "codigo no puede ser nulo o vacio.");

    Console.Write("Ingrese la descripcion del producto: ");
    string descripcion = Console.ReadLine();
    Validacion.ValidacionStringEmptyOrNull(descripcion, "descripcion no puede ser nulo o vacio.");

    Console.Write("Ingrese el stock:");
    int stock = Convert.ToInt32(Console.ReadLine());
    Validacion.ValidacionStock(stock);

    Console.Write("Ingrese el precio unitario del producto: ");
    float precioUnitario = float.Parse(Console.ReadLine());
    Validacion.ValidacionPrecio(precioUnitario);

    Producto producto = new Producto{
        Nombre = nombre,
        Codigo = codigo,
        Descripcion = descripcion,
        Stock = stock,
        PrecioUnitario = precioUnitario
    };

    tienda1.AgregarProducto(producto);

    Console.Write("Ingrese el nombre del producto(para parar el ingreso, no ingrese nada): ");
    nombre = Console.ReadLine();
}

Producto productoTest = new Producto{
    Nombre = "test",
    Codigo = "12",
    Descripcion = "afsdfasdf",
    Stock = 43,
    PrecioUnitario = 1234
};

tienda1.AgregarProducto(productoTest);
tienda1.Buscar(false, "12");
tienda1.Buscar(true, "test");
Console.WriteLine(tienda1.Mostrar());
tienda1.EliminarProducto("12");
Console.WriteLine(tienda1.Mostrar());
//tienda1.Buscar(false, "12");