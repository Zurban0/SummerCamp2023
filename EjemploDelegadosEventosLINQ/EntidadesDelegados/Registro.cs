using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesEventos
{
    public class Registro
    {
        private DateTime fechaBaseParaCalculoSegundos = DateTime.Now;
        private static int SEGUNDOS_PARA_REGISTRO = 10;
        public void Suscribir(Reloj reloj, StringChange stringChange)
        { 

            reloj.CambioSegundoEvento += Reloj_CambioSegundoEvento;
        }

        private void Reloj_CambioSegundoEvento(Reloj reloj, InformacionTiempoEventArgs e, StringChange stringChange)
        {
            if ((int)DateTime.Now.Subtract(fechaBaseParaCalculoSegundos).Seconds >= SEGUNDOS_PARA_REGISTRO)
            {
                stringChange.MyStringProperty = $"Hora de Registro: {e}";
                fechaBaseParaCalculoSegundos = DateTime.Now;
            }

        }
    }
}
