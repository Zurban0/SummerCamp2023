namespace Extensiones
{
    public static class Utilidades
    {

        public static string ConvertirCadena(this string cadena)
        {
            return cadena.Trim().ToUpper()+".";
        }

        public static bool EsMayorQueB(this int a, int b)
        {
            return a > b;
        }
        public static int Primero(this List<int> lista)
        {
            return lista.FirstOrDefault();
        }
    }
}