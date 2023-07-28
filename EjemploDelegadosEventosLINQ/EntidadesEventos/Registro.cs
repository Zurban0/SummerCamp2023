using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEventos
{
    public class Registro
    {
        private DateTime llamada = DateTime.Now;
        public void Suscribir(Reloj reloj)
        { 

            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        private void Reloj_CambioSegundoEvento(object reloj, InformacionTiempoEventArgs e)
        {
            if ((int)DateTime.Now.Subtract(llamada).Seconds >= 10)
            {
                Console.WriteLine($"Hora Registrada: {e.Hora.ToString()}:{e.Minuto.ToString()}:{e.Segundo.ToString()}");
                llamada = DateTime.Now;
            }

        }
    }
}
