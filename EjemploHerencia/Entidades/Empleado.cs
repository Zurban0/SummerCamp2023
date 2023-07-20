using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    public partial class Empleado
    {
        public Empleado(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; set; }

        protected double diasVacaciones;

        public override string ToString()
        {
            return Nombre + "es un empleado"; 
        }

    }
}