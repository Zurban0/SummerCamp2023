

namespace EjemploHerencia
{
    public class Trabajador : Empleado
    {
        public Trabajador(string nombre) : base(nombre) { }

        public override string ToString()
        {
            return Nombre + "Es un trabajador";
        }
    }
}