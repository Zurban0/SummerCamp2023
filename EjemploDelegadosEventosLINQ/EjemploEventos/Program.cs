using EjemploEventos.Negocio;
using EntidadesEventos;

namespace EjemploEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller.InicializarControladorEventoVariable();
            Controller.SuscribirARegistro();
            Controller.SuscribirARelojDigital();
            Controller.IniciarReloj();
        }
        
    }
}