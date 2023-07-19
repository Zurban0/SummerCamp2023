namespace Entidades
{
    public class Moneda
    {
        public Moneda(double valor, TipoMoneda tipo)
        {
            Valor=valor;
            Tipo=tipo;
        }

        public double Valor { get; set; }
        public TipoMoneda Tipo { get; set; }
    }
    public enum TipoMoneda
    {
        Euros,
        Dolares,
        Libras
    }
}