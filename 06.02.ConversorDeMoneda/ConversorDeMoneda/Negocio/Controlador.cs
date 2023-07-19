
using Entidades;

namespace ConversorDeMoneda
{
    static class Controlador
    {
        public static List<Moneda> monedas = new List<Moneda>();
        public static void CrearMonedas()
        {
            monedas.Add(new Moneda(3, TipoMoneda.Libras));
            monedas.Add(new Moneda(5, TipoMoneda.Euros));
            monedas.Add(new Moneda(1, TipoMoneda.Dolares));
        }
        public static double ConvertirMoneda(int tipoMonedaOrigen, int tipoMonedaDestino, double dineroAConvertir)
        {
            Moneda moneda1 = BuscarMonedaPorTipo(tipoMonedaOrigen);
            Moneda moneda2 = BuscarMonedaPorTipo(tipoMonedaDestino);

            return (moneda2.Valor / moneda1.Valor) *  dineroAConvertir;

            
        }

        private static Moneda BuscarMonedaPorTipo(int tipoMoneda)
        {
            return monedas.Find(m => m.Tipo == (TipoMoneda)tipoMoneda);
        }



    }
}
