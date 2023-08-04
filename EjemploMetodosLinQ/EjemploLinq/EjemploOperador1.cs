using System.IO.Pipes;

namespace EjemploLinq
{
    internal class EjemploOperador1
    {
            IEnumerable<Empleado> Empleados = new List<Empleado>()            {                 new Empleado                 {                     Nombre = "Jose",                     Apellidos = "Conde",                     Ciudad = "Madrid",                     Telefono = "123456789",                     Departamento = Departamento.Desarrollo                 },                 new Empleado                 {                     Nombre = "Luis",                     Apellidos = "Castillo",                     Ciudad = "Madrid",                     Telefono = "423456789",                     Departamento = Departamento.Soporte                 },                 new Empleado                 {                     Nombre = "Juan",                     Apellidos = "Nuñez",                     Ciudad = "Barcelona",                     Telefono = "9123456789",                     Departamento = Departamento.RH                 },                 new Empleado                 {                     Nombre = "Maria",                     Apellidos = "Garcia",                     Ciudad = "Valencia",                     Telefono = "8123456789",                     Departamento = Departamento.Admin                 }            };

         IEnumerable<Empleado> EmpleadosNuevos = new List<Empleado>            {                new Empleado                {                    Nombre = "Fabricio",                    Apellidos = "Cordero",                    Departamento = Departamento.Desarrollo                },                new Empleado                {                    Nombre = "Julia",                    Apellidos = "Lombardo",                    Departamento = Departamento.Admin                },            };
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