﻿using System.IO.Pipes;

namespace EjemploLinq
{
    internal class EjemploOperador1
    {
            IEnumerable<Empleado> Empleados = new List<Empleado>()

         IEnumerable<Empleado> EmpleadosNuevos = new List<Empleado>
        internal void Ejecutar()
        {
            List<Empleado> empleadosDesarrolloSoporte = EjecutarPorEntity();

            empleadosDesarrolloSoporte.ForEach(e => Console.WriteLine(e.Nombre));
        }

        private List<Empleado> EjecutarPorEntity()
        {
            return Empleados.Where(e => TrabajaEnDesarrolloOSoporte(e) && ApellidoEmpleadoEmpiezaPorC(e))
                .OrderByDescending(e => e.Nombre).ToList();
        }private List<Empleado> EjecutarPorLinq()
        {
            return (from e in Empleados
                    where TrabajaEnDesarrolloOSoporte(e) && ApellidoEmpleadoEmpiezaPorC(e)
                    orderby e.Nombre descending
                    select e).ToList();
        }
        private bool TrabajaEnDesarrolloOSoporte(Empleado e)
        {
            return e.Departamento == Departamento.Desarrollo || e.Departamento == Departamento.Soporte;
        }
        private bool ApellidoEmpleadoEmpiezaPorC(Empleado e)
        {
            return e.Apellidos.ToUpper().StartsWith("C");
        }

        public void ListadoTelefonos()
        {
            //List<Empleado> empleadosDesarrolloSoporte = ListadoTelefonosPorEntity();
            List<string> empleadosDesarrolloSoporte = ListadoTelefonosPorEntity();

            empleadosDesarrolloSoporte.ForEach(e => Console.WriteLine(e));
        }

        private List<string> ListadoTelefonosPorEntity()
        {
            return Empleados.Where(e => ViveEnMadrid(e) && SuApellidoContieneA(e)).OrderBy(e => e.Nombre).Select(e => e.Telefono).ToList();
        }
        private void ListadoTelefonosPorLinq()
        {
             (from e in Empleados
                    where ViveEnMadrid(e) && SuApellidoContieneA(e)
                    orderby e.Nombre
                    select new { e.Telefono, e.Ciudad }).ToList();
        }

        private bool SuApellidoContieneA(Empleado e)
        {
            return e.Apellidos.ToUpper().Contains("A");
        }

        private bool ViveEnMadrid(Empleado e)
        {
            return e.Ciudad.ToUpper().Equals("MADRID");
        }


        public void AniadirEmpleadosNuevos()
        {
            List<Empleado> empleados = (List<Empleado>)Empleados;
            empleados.AddRange(EmpleadosNuevos);
        }

    }
}