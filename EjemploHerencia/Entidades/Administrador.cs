using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Administrador : Empleado
    {
        public Administrador() { }
        public Administrador(string nombre, Turno turno, int? plazaParking, string? telefono, Empleado? jefe) : base(nombre, telefono, jefe)
        {
            Turno = turno;
            PlazaParking = plazaParking;
        }

        public Turno Turno { get; set; }

        public int? PlazaParking { get; set; } = null;

        public override void CalculoVacaciones()
        {
            diasVacaciones = +9;
        }

        public override string ToString()
        {
            string plazaParking = PlazaParking is null ? "\nNo tiene plaza de parking" : "\nPlaza de parking: "+PlazaParking;
            string telefonoVacacionesSuperior = SacarTelefonoDiasVacacionesSuperior();

            return Nombre + " es un Administrador"+plazaParking+"\nTurno: "+Turno+telefonoVacacionesSuperior;
        }
    }
}