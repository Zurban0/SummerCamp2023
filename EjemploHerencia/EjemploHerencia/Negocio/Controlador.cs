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
        private const string STRING_NAME_TRABAJADOR = "Trabajador";
        private const string STRING_NAME_ADMINISTRADOR = "Administrador";
        private const string STRING_NAME_EXTERNO = "Externo";
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
        
        public static List<string> ObtenerDatosSegunClases()
        {
            return empleados.Select(e => ObtenerResultadoSegunClase(e)).ToList();
            //return (from empleado in empleados.Distinct()
            //        select ObtenerResultadoSegunClase(empleado)).ToList();
        }

        private static string ObtenerResultadoSegunClase(Empleado empleado)
        {
            string mensaje = "";

            switch (empleado.GetType().Name)
            {
                case STRING_NAME_TRABAJADOR:
                    mensaje = ObtenerTurno(empleado);
                    break;
                case STRING_NAME_ADMINISTRADOR:
                    mensaje = ObtenerPlazaParking(empleado);
                    break;
                case STRING_NAME_EXTERNO:
                    mensaje = ObtenerNombreEmpresa(empleado);
                    break;
                default:
                    mensaje = "No tiene ninguna clase en especifico";
                    break;
            }

            return mensaje;
        }

        private static string ObtenerTurno(Empleado empleado)
        {
            Trabajador trabajador = (Trabajador)empleado;
            return trabajador.Nombre +" es trabajador. Su turno es de "+ trabajador.Turno;
        }

        private static string ObtenerPlazaParking(Empleado empleado)
        {
            Administrador administrador = (Administrador)empleado;
            string mensaje = "";
            try
            {
                if(administrador.PlazaParking is not null) {
                    mensaje = administrador.Nombre + " es administrador. Su plaza de parking es "+ administrador.PlazaParking;
                    throw new ErrorBaseDatosException("Error al conectar a BBDD", DateTime.Now);
                } else
                {
                    mensaje = administrador.Nombre + " es administrador pero no tiene plaza de parking";
                }
            }
            catch (ErrorBaseDatosException ex)
            {
                mensaje = ex + "\nFecha y hora del error: " + ex.FechaHora.ToString();
            }
            return mensaje;
        }

        private static string ObtenerNombreEmpresa(Empleado empleado)
        {
            Externo externo = (Externo)empleado;
            return externo.Nombre +" es externo. El nombre de su empresa es "+ externo.Empresa.Nombre;
        }

    }
}
