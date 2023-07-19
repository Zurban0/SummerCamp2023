using Entidades;

namespace VehiculosSegunConstructor
{
    static class Controlador
    {
        static Vehiculo vehiculo = null;
        public static void CrearVehiculo(DateTime anioCompra, int color, string marca, string modelo)
        {
            vehiculo = new Vehiculo(anioCompra, (Color)color, marca, modelo);
        }
        public static void CrearVehiculo(DateTime anioCompra, int color)
        {
            vehiculo = new Vehiculo(anioCompra, (Color)color);
        }
        public static void CrearVehiculo(string marca, string modelo)
        {
            vehiculo = new Vehiculo(marca, modelo);
        }
        public static Object ObtenerDatosVehiculo()
        {
            return vehiculo;
        }
        public static void ResetearVehiculo()
        {
            vehiculo = null;
        }
    }
}
