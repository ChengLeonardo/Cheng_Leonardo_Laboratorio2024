using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente : Persona
    {
        public decimal LimiteCredito { get; set; }
        public Cliente(string Nombre, string Apellido, string Domicilio, decimal LimiteCredito)
            :base(Nombre, Apellido, Domicilio)
        {
            this.LimiteCredito = LimiteCredito;
        }
    }
}