using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEventos
{
    public class RelojDigital
    {
        public void Suscribir(Reloj reloj, StringChange stringChange)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        private void Reloj_CambioSegundoEvento(Reloj reloj, InformacionTiempoEventArgs e, StringChange stringChange)
        {
            stringChange.MyStringProperty = $"Hora Actual: {e}";
        }
    }
}
