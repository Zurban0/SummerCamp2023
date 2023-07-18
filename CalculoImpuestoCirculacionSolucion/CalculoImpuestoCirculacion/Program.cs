namespace CalculoImpuestoCirculacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            bool mostrarResultado = false;
            do
            {
                Console.WriteLine("1- Nuevo vehículo");
                Console.WriteLine("2- Calcular");

                mostrarResultado = program.PreguntarSiCalcularResultados();
                if (!mostrarResultado)
                {
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

                    double valorVehiculo = program.PreguntarPorValorVehiculo();
                    Controlador.ImportarVehiculo(valorVehiculo, fechaCirculacion, tipoEtiqueta);
                }
                else
                {
                    var impuestos = Controlador.DevolverValorVehiculos();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    program.MostrarResultados(impuestos);

                }

            } while (!mostrarResultado);




        }

        private void MostrarResultados(List<double> impuestos)
        {
            int i = 0;
            foreach (var impuesto in impuestos)
            {
                i+=1;
                Console.Write("Vehiculo "+i+": ");
                Console.WriteLine(impuesto+"€");
            }
        }

        private bool PreguntarSiCalcularResultados()
        {
            bool numCorrecto;
            int resultado = 0;

            do
            {
                numCorrecto = true;
                Console.Write("Escribe el tipo: ");
                try
                {
                    resultado = int.Parse(Console.ReadLine());
                    if (resultado < 1 || resultado > 2)
                    {
                        numCorrecto = false;
                    }
                }
                catch (Exception)
                {

                    numCorrecto = false;
                }
            } while (numCorrecto == false);

            return resultado == 2;
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