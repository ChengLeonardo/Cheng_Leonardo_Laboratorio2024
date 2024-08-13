using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empleado : Persona
    {
        public decimal LimiteSalario { get; set; }
        public Empleado(string Nombre, string Apellido, string Domicilio, decimal LimiteSalario):base(Nombre, Apellido, Domicilio)
        {
            this.LimiteSalario = LimiteSalario;
        }
    }
}