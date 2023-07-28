using EntidadesEventos;
using System.ComponentModel;

namespace EjemploEventos.Negocio
{
    public static class Controller
    {
        private static Reloj reloj = new();
        private static RelojDigital relojDigital = new();
        private static Registro registro = new();
        private static StringChange stringChange = new();


        public static void InicializarControladorEventoVariable()
        {
            stringChange.PropertyChanged += MyClass_PropertyChanged;
        }
        public static void IniciarReloj()
        {
            reloj.IniciarReloj(stringChange);

        }

        public static void SuscribirARelojDigital()
        {
            relojDigital.Suscribir(reloj, stringChange);
        }

        public static void SuscribirARegistro()
        {
            registro.Suscribir(reloj, stringChange);
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
