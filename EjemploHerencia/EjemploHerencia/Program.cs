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
            program.PreguntarPorMasEmpleados();
        }
        private void MostrarResultados(List<string> empleados)
        {
            empleados.ForEach(e => Console.WriteLine(e+"\n"));
        }

        private bool PreguntarPorMasEmpleados()
        {
            string result;
            do
            {
                Console.Write("¿Quieres crear mas personas(Y/N)?: ");
                result = Console.ReadLine().ToUpper();
            } while (result != "Y" && result != "N");
            
            return result == "Y";

        }

    }
}