using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    public static class Controlador
    {
        private static List<Empleado> empleados = new List<Empleado>();
        public static void CrearDiferentesClases()
        {
            Administrador maria = new Administrador("Maria", Turno.Trade, 223, "658742364", null);

            Empleado juan = new Trabajador("Juan", Turno.Mañana, null, maria);

            Empresa empresaPedro = new Empresa("Tigloo");

            var pedro = new Externo("Pedro", empresaPedro, null, null);

            empleados.Add(juan);
            empleados.Add(maria);
            empleados.Add(pedro);

            CalcularDiasVacacionesPorNombre("j");

        }

        public static void CalcularDiasVacacionesPorNombre(string nombre)
        {
            empleados.Where(e => e.Nombre.ToUpper().StartsWith(nombre.ToUpper())).OrderBy(e => e.Nombre).ToList().ForEach(e => e.CalculoVacaciones());

            //(from empleado in empleados.Distinct()
            // where empleado.Nombre.ToUpper().StartsWith(nombre.ToUpper())
            // orderby empleado.Nombre
            // select empleado).ToList().ForEach(e => e.CalculoVacaciones());
        }

        public static List<string> ObtenerToStringClases()
        {
            return (from empleado in empleados.Distinct()
                    select empleado.ToString()).ToList();
        }
    }
}
