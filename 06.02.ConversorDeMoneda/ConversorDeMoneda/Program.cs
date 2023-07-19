namespace ConversorDeMoneda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controlador.CrearMonedas();
            Console.WriteLine(Controlador.ConvertirMoneda(0, 1, 10));
        }
    }
}