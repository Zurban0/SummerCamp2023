using EntidadesEventos;

namespace EjemploEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reloj reloj = new();
            RelojDigital relojDigital = new();
            relojDigital.Suscribir(reloj);

            var log = new Registro();
            log.Suscribir(reloj);


            reloj.IniciarReloj();

        }
    }
}