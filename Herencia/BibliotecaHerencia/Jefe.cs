using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaHerencia
{
    public class Jefe : Persona
    {
        public int Edad { get; set; }
        public decimal Sueldo { get; set; }
        public void InformarNombreCompleto()
        {
            Console.WriteLine($"{Nombre.ToUpper()} {Apellido.ToUpper()}");
        }
    }
}