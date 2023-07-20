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
            Empleado juan = new Trabajador("Juan");
            Administrador maria = new Administrador("Maria");
            juan.Jefe = maria;
            var jose = new Trabajador("Jose");

            empleados.Add(juan);
            empleados.Add(maria);
            empleados.Add(jose);

        }

        public static List<string> ObtenerToStringClases()
        {
            return (from empleado in empleados.Distinct()
                    select empleado.ToString()).ToList();
        }
    }
}
