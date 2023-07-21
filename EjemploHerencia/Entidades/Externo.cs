using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Externo : Empleado
    {
        public Externo(string nombre, Empresa empresa, string? telefono, Empleado? jefe) : base(nombre, telefono, jefe)
        {
            Empresa=empresa;
        }

        public Empresa Empresa { get; set; }

        public override string ToString()
        {
            string telefonoVacacionesSuperior = SacarTelefonoDiasVacacionesSuperior();

            return Nombre + " es un externo.\nNombre de la empresa: "+Empresa.Nombre+telefonoVacacionesSuperior;
        }
    }
}