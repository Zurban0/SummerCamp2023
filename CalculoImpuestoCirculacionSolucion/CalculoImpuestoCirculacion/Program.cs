namespace CalculoImpuestoCirculacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();

            DateTime fechaCirculacion = program.PreguntarPorFechaCirculacion();

            Console.WriteLine("Tipo de etiqueta");
            Console.WriteLine("");
            Console.WriteLine("1- Sin etiqueta");
            Console.WriteLine("2- Etiqueta B");
            Console.WriteLine("3- Etiqueta C");
            Console.WriteLine("4- Etiqueta ECO");
            Console.WriteLine("5- Etiqueta CERO");
            Console.WriteLine("");


            var tipoEtiqueta = program.PreguntarPorTipoEtiqueta();  
            
            var valorVehiculo = program.PreguntarPorValorVehiculo();

            var impuesto = Controlador.CalcularImpuesto(valorVehiculo, fechaCirculacion, tipoEtiqueta);

            Console.WriteLine("Impuesto: " + impuesto);

        }

        private DateTime PreguntarPorFechaCirculacion()
        {
            bool esNumero;
            int dia = 0;
            int mes = 0;
            int anio = 0;

            do
            {
                esNumero = true;
                try
                {
                    Console.Write("Dia: ");
                    dia = int.Parse(Console.ReadLine());
                    if ( dia > 31 || dia <= 0 )
                    {
                         esNumero = false;
                    }
                    Console.Write("Mes: ");
                    mes = int.Parse(Console.ReadLine());
                    if (mes > 12 || mes <= 0)
                    {
                        esNumero = false;
                    }

                    Console.Write("Año: ");
                    anio = int.Parse(Console.ReadLine());
                    if (anio > DateTime.Now.Year || anio <= 0)
                    {
                        esNumero = false;
                    }
                }
                catch (Exception)
                {

                    esNumero = false;
                }
            } while (esNumero == false);

            return new DateTime(anio, mes, dia);
        }
        private int PreguntarPorTipoEtiqueta()
        {
            bool tipoEtiquetaCorrecta;
            int tipoEtiqueta = 0;

            do
            {
                tipoEtiquetaCorrecta = true;
                Console.Write("Escribe el tipo: ");
                try
                {
                    tipoEtiqueta = int.Parse(Console.ReadLine());
                    if (tipoEtiqueta > 5 || tipoEtiqueta < 1)
                    {
                        tipoEtiquetaCorrecta = false;
                    }
                }
                catch (Exception)
                {

                    tipoEtiquetaCorrecta = false;
                }
            } while (tipoEtiquetaCorrecta == false);

            return tipoEtiqueta;
        }

        private double PreguntarPorValorVehiculo()
        {
            bool valorVehiculoCorrecto;
            double valorVehiculo = 0;
            do
            {
                valorVehiculoCorrecto = true;
                Console.Write("Valor del Vehículo: ");
                try
                {
                    valorVehiculo = double.Parse(Console.ReadLine());
                    if (valorVehiculo < 0)
                    {
                        valorVehiculoCorrecto = false;
                    }
                }
                catch (Exception)
                {

                    valorVehiculoCorrecto = false;
                }
            } while (valorVehiculoCorrecto == false);
            return valorVehiculo;

        }
    }
}