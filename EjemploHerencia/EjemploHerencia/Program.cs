using System;
using System.Security.AccessControl;

namespace EjemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controlador.CrearDiferentesClases();
            Program program = new Program();
            program.MostrarResultados(Controlador.ObtenerToStringClases());
        }
        private void MostrarResultados(List<string> empleados)
        {
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado);
            }
        }

    }
}