using EjemploEventos.Negocio;
using EntidadesEventos;

namespace EjemploEventos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller.InicializarControladorEventoVariable();
            Controller.SuscribirARegistro();
            Controller.SuscribirARelojDigital();
            Controller.IniciarReloj();
        }

        private static void MyClass_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "MyStringProperty")
            {
                Console.WriteLine(stringChange.MyStringProperty);
            }
        }
    }
}