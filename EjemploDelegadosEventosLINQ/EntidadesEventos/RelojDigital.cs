using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEventos
{
    public class RelojDigital
    {
        public void Suscribir(Reloj reloj)
        {
            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs e)
        {
            
            Console.WriteLine($"Hora Actual: {e.Hora.ToString()}:{e.Minuto.ToString()}:{e.Segundo.ToString()}");
        }
    }
}
