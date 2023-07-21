

namespace Entidades
{
    public class Trabajador : Empleado
    {
        public Trabajador() { }
        public Trabajador(string nombre, Turno turno, string? telefono, Empleado? jefe) : base(nombre, telefono, jefe) 
        { 
            Turno = turno;
        }
        public Turno Turno { get; set; }

        public override void CalculoVacaciones()
        {
            base.CalculoVacaciones();
            diasVacaciones += 15;
        }
        public override string ToString()
        {
            string telefonoVacacionesSuperior = SacarTelefonoDiasVacacionesSuperior();

            return Nombre + " es un trabajador"+telefonoVacacionesSuperior;
        }
    }

    
}