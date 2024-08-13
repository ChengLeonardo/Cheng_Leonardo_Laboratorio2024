using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaHerencia
{
    public class Empleado : Persona
    {
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public void InformarNombreCompleto()
        {
            Console.WriteLine($"{Nombre} {Apellido}");
        }
    }
}