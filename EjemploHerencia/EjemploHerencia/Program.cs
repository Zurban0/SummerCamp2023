﻿using System;
using System.Security.AccessControl;

namespace EjemploHerencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controlador.CrearDiferentesClases();
            Program program = new Program();
            //program.MostrarResultados(Controlador.ObtenerToStringClases());
            program.MostrarResultados(Controlador.ObtenerDatosSegunClases());
        }
        private void MostrarResultados(List<string> mensajeEmpleados)
        {
            mensajeEmpleados.ForEach(e => Console.WriteLine(e+"\n"));
        }


    }
}