using Entidades;
using System.Runtime.CompilerServices;

namespace CalculoImpuestoCirculacion
{
    static class Controlador
    {
        private static List<Vehiculo> vehiculos = new List<Vehiculo>();
        public static void ImportarVehiculo(double valorBase, DateTime anioMatriculacion, int Etiqueta)
        {
            var vehiculo = new Vehiculo()
            {
                ValorBase = valorBase,
                AnioMatriculacion = anioMatriculacion,
                EtiquetaDGT = (EtiquetaDGT)Etiqueta,
            };
            vehiculo.Impuesto = CalcularImpuesto(vehiculo);

            vehiculos.Add(vehiculo);
        }
        public static List<double> DevolverValorVehiculos()
        {
            return (from vehiculo in vehiculos.Distinct()
                   select vehiculo.Impuesto).ToList();
        }
       private static double CalcularImpuesto(Vehiculo vehiculo)
        {
            double impuesto = vehiculo.ValorBase;

            

            var anioAntiguedad = CalcularAnioAntiguedadVehiculo(vehiculo.AnioMatriculacion);

            impuesto += SumarPorAnioAntiguedad(vehiculo.ValorBase, anioAntiguedad);
            impuesto += SumarPorTipoEtiqueta( vehiculo.ValorBase, vehiculo.EtiquetaDGT);

            return impuesto;
        }

        private static double SumarPorTipoEtiqueta(double impuesto, EtiquetaDGT etiqueta)
        {
            double porcentaje = 0;

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

            return CalcularPorcentajeAImpuesto(impuesto, porcentaje);
        }       

        private static double SumarPorAnioAntiguedad(double impuesto, double anioAntiguedad)
        {
            return CalcularPorcentajeAImpuesto(impuesto, anioAntiguedad);

        }

        private static double CalcularPorcentajeAImpuesto(double impuesto, double porcentaje)
        {
            return impuesto * (1 + porcentaje / (double)100);
        }

        private static double CalcularAnioAntiguedadVehiculo(DateTime anioMatriculacion)
        {
            DateTime fechaActual = DateTime.Now;
            double anioAntiguedad = fechaActual.Year - anioMatriculacion.Year;
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
