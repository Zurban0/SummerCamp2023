namespace Entidades
{
    public class Vehiculo
    {
        public Vehiculo(DateTime anioCompra, Color color, string marca, string modelo) : this(anioCompra, color)
        {
            Marca=marca;
            Modelo=modelo;
            
        }
        public Vehiculo(DateTime anioCompra, Color color)
        {
            AnioCompra=anioCompra;
            Color=color;
        }
        public Vehiculo(string marca, string modelo)
        {
            Marca=marca;
            Modelo=modelo;
        }
        public Vehiculo() { }


        public DateTime? AnioCompra { get; set; } = null;
        public Color? Color { get; set; } = null;
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public override string ToString()
        {
            string anioCompra = AnioCompra == null ? "" : AnioCompra.ToString();
            string color = Color == null ? "" : Color.ToString();
            return String.Concat("Año de compra: " +  anioCompra +"\nColor: "+ color + "\nMarca: "+ Marca + "\nModelo: "+Modelo);
        }

    }

    public enum Color
    {
       Rojo,
       Verde,
       Azul,
       Blanco,
       Negro,
       Amarillo
    }

}