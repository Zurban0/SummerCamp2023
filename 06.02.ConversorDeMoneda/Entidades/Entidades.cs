namespace Entidades
{
    public class Moneda
    {
        public Moneda(int id, double valor, string tipo)
        {
            Id = id;
            Valor=valor;
            Tipo=tipo;
        }
        public int Id { get; set; }
        public double Valor { get; set; }
        public string Tipo { get; set; }
        public override string ToString()
        {
            return String.Concat(Id+"."+Tipo+"("+Valor+")");
        }
    }


}