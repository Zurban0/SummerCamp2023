using static EjemploDelegados.InventarioMedios;

namespace EjemploDelegados
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            InventarioMedios inventarioMedios = new InventarioMedios();
            Console.WriteLine(inventarioMedios.HacerPruebaResultadoMedios());
            Console.WriteLine(inventarioMedios.HacerPruebaResultadoContenido());
        }

    }
}