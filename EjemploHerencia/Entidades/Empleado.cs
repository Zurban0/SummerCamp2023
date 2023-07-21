using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public partial class Empleado
    {
        public Empleado() { }
        public Empleado(string nombre, string? telefono, Empleado? jefe)
        {
            Nombre = nombre;
            Telefono = telefono;
            Jefe = jefe;
        }

        public string Nombre { get; set; }
        protected double diasVacaciones;
        public virtual void CalculoVacaciones()
        {
            diasVacaciones += 10;
        }
        protected virtual string SacarTelefonoDiasVacacionesSuperior()
        {
            string resultado = Telefono == null ? "\nNo tiene número de teléfono" : "\nTeléfono: " + Telefono;
            resultado += Jefe == null ? "\nNo tiene ningun superior" : "\nJefe: "+Jefe.Nombre;
            resultado += diasVacaciones == 0 ? "\nNo tiene dias de vacaciones" : "\nDias de vacaciones: " + diasVacaciones;

            return resultado;

        }
        public override string ToString()
        {
            string telefonoVacacionesSuperior = SacarTelefonoDiasVacacionesSuperior();
            return Nombre + " es un empleado."+telefonoVacacionesSuperior; 
        }

    }
}