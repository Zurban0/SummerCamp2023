
namespace EntidadesEventos
{
    public class Reloj
    {
        //Delegado
        public delegate void CambioSegundoDelegado(Reloj reloj, InformacionTiempoEventArgs informacionTiempo, StringChange stringChange);

        //Evento
        public event CambioSegundoDelegado CambioSegundoEvento;
        public Reloj() { }
        private int segundo;
        public void IniciarReloj(StringChange stringChange)
        {
            DateTime fechaHoraActual;
            for(;;)
            {
                Thread.Sleep(100);

                fechaHoraActual  = DateTime.Now;

                if(fechaHoraActual.Second != segundo)
                {
                    var informacionTiempo = new InformacionTiempoEventArgs(fechaHoraActual.Hour, fechaHoraActual.Minute, fechaHoraActual.Second);

                    if(CambioSegundoEvento != null)
                    {
                        CambioSegundoEvento(this, informacionTiempo, stringChange);
                    }           
                }
                segundo  = fechaHoraActual.Second;
            }
        }
    }
}
