
namespace VehiculosSegunConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controlador.CrearVehiculo("Ford", "R32");
            Console.WriteLine(Controlador.ObtenerDatosVehiculo().ToString()+"\n");
            Controlador.CrearVehiculo(new DateTime(2015, 05, 10), 1);
            Console.WriteLine(Controlador.ObtenerDatosVehiculo().ToString()+"\n");
            Controlador.CrearVehiculo(new DateTime(2015, 05, 10), 1, "Ford", "R32");
            Console.WriteLine(Controlador.ObtenerDatosVehiculo().ToString()+"\n");
        }
    }
}