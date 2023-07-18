using Entidades;
using System.Runtime.CompilerServices;

namespace CalculoImpuestoCirculacion
{
    static class Controlador
    {
       public static double CalcularImpuesto(double valorBase, DateTime anioMatriculacion, int Etiqueta)
        {
            double impuesto = valorBase;

            var vehiculo = new Vehiculo()
            {
                ValorBase = valorBase,
                AnioMatriculacion = anioMatriculacion,
                EtiquetaDGT = (EtiquetaDGT)Etiqueta,
            };

            var anioAntiguedad = CalcularAnioAntiguedadVehiculo(vehiculo.AnioMatriculacion);

            impuesto = SumarPorAnioAntiguedad(impuesto, anioAntiguedad);
            impuesto = SumarPorTipoEtiqueta(impuesto, vehiculo.EtiquetaDGT);

            return impuesto;
        }

        private static double SumarPorTipoEtiqueta(double impuesto, EtiquetaDGT etiqueta)
        {
            int porcentaje = 0;

            switch (etiqueta)
            {
                case EtiquetaDGT.SinEtiqueta:
                    porcentaje = 25;
                    break;
                case EtiquetaDGT.B:
                    porcentaje = 15;
                    break;
                case EtiquetaDGT.C:
                    porcentaje = 10;
                    break;
                case EtiquetaDGT.ECO:
                    porcentaje = 5;
                    break;
                case EtiquetaDGT.CERO:
                    porcentaje = 0;
                    break;
                default:
                    break;
            }

            return CalcularPorcentajeAImpuesto(impuesto, porcentaje) + impuesto;
        }

        private static double SumarPorAnioAntiguedad(double impuesto, int anioAntiguedad)
        {
            return CalcularPorcentajeAImpuesto(impuesto, anioAntiguedad) + impuesto;

        }

        private static double CalcularPorcentajeAImpuesto(double impuesto, int porcentaje)
        {
            return (impuesto * (porcentaje / 100));
        }

        private static int CalcularAnioAntiguedadVehiculo(DateTime anioMatriculacion)
        {
            DateTime fechaActual = DateTime.Now;
            int anioAntiguedad = fechaActual.Year - anioMatriculacion.Year;
            if ( anioMatriculacion.Month < fechaActual.Month)
            {
                anioAntiguedad += 1;
            }else if (anioMatriculacion.Month == fechaActual.Month)
            {
                if(anioMatriculacion.Day <= fechaActual.Day)
                {
                    anioAntiguedad += 1;
                }
            }

            return anioAntiguedad;

        }
    }
}
