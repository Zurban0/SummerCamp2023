﻿using Entidades;

namespace ConversorDeMoneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program programa = new Program();

            Controlador.CrearMonedas();

            int monedaOrigen = programa.PedirTipoMoneda("origen");
            int monedaDestino = programa.PedirTipoMoneda("destino");
            double dineroAConvertir = programa.PedirDineroAConvertir();

            Console.WriteLine(Controlador.ConvertirMoneda(monedaOrigen, monedaDestino, dineroAConvertir));


        }

        private double PedirDineroAConvertir()
        {
            bool dineroCorrecto = false;
            double dineroAConvertir = 0;

            do
            {
                Console.Write("Ingresa el dinero a convertir: ");
                if(double.TryParse(Console.ReadLine(), out dineroAConvertir))
                {
                    if (dineroAConvertir >= 0)
                    {
                        dineroCorrecto = true;

                    }
                }

            } while (!dineroCorrecto);
            return dineroAConvertir;
        }

        private int PedirTipoMoneda(string tipoMoneda)
        {
            bool respuestaCorrecta = false;
            int moneda = 0;

            string comentario = "Elige el tipo de moneda " + tipoMoneda;
            List<string> toStringMonedas = Controlador.ObtenerToStringDeMonedas();
            foreach (var toStringMoneda in toStringMonedas)
            {
                comentario += " "+toStringMoneda;
            }
            comentario+=": ";
            do
            {
                Console.Write(comentario);
                if (int.TryParse(Console.ReadLine(), out moneda) )
                {
                    if (moneda >= 0 && moneda <= toStringMonedas.Count)
                    {
                        respuestaCorrecta = true;

                    }
                }

            } while (!respuestaCorrecta);
            return moneda;
        }
    }
}
