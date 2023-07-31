namespace EjemploMetodosExtension
{
    using Extensiones;
    using System.Data;

    internal class Program
    {
        static void Main(string[] args)
        {
            var juan = "Juan".ConvertirCadena();
            var luis = "Luis".ConvertirCadena();

            //Agregar método de extensión para comparar dos enteros.

            int a = 0;
            int b = 0;
            Console.WriteLine(a.EsMayorQueB(b) ? "Es Mayor" : "Es Menor");

            var lista = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(lista.Primero());
        }
    }
}