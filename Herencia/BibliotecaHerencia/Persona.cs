namespace BibliotecaHerencia
{
    public class Persona // clase Padre(teoria) / Super clase (java) / clase base (c#)
    {
        public string Nombre { get; set; }
        public string Apellido {get; set; }
        public string Email { get; set; }

        public void InformarNombreCompleto()
        {
            Console.WriteLine($"{Apellido}, {Nombre}");
        }
    }
}