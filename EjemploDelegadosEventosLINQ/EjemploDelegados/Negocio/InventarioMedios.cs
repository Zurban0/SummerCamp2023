
namespace EjemploDelegados
{
    internal class InventarioMedios
    {
        public delegate bool ProbarMediosDelegado();

        public delegate List<string> MostrarContenido();

        private Tocadiscos tocadiscos = new();
        private Vinilo vinilo = new();
        private ReproductorCDs reproductorCD = new();

        public string HacerPruebaResultadoMedios()
        {
            ProbarMediosDelegado probarMediosDelegado = new ProbarMediosDelegado(tocadiscos.ProbarTocadiscos);
            return ResultadoProbarMedios(probarMediosDelegado);

        }
        private string ResultadoProbarMedios(ProbarMediosDelegado probarMediosDelegado)
        {
            var resultadoPrueba = probarMediosDelegado();

            if (resultadoPrueba)
            {
                return "Resultado de la prueba satisfactoria\n";
            }
            else
            {
                return "Resultado de la prueba fallida\n";
            }
        }
        

        public string HacerPruebaResultadoContenido()
        {
            string resultadoContenido = "";

            resultadoContenido += ResultadoContenido(new MostrarContenido(tocadiscos.MostrarInformacionCancion));
            resultadoContenido += ResultadoContenido(new MostrarContenido(vinilo.MostrarListaCancionesEnContraportada));
            resultadoContenido += ResultadoContenido(new MostrarContenido(reproductorCD.MostrarListaCanciones));

            return resultadoContenido;
        }
        private string ResultadoContenido(MostrarContenido mostrarContenido)
        {
            string resultado = "";
            List<string> list = mostrarContenido();

            list.ForEach(l => resultado+=l+"\n");
            resultado+="\n";

            return resultado;
        }
       
    }
}
