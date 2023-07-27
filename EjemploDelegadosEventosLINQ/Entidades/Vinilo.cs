using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    public class Vinilo
    {
        public bool ProbarVinilo()
        {
            Console.WriteLine("Por favor, ponga el cd en el reproductor");
            Console.WriteLine("Pulsa el botón de reproducción");
            Console.WriteLine("Indique a continuación si ha escuchado algo");

            var result = Console.ReadLine();

            return result.ToUpper().Equals("S");
        }

        public List<string> MostrarListaCancionesEnContraportada()
        {

            return new List<string>
            {
                "CONTRAPORTADA: ",
                "1 -- Volvere",
                "2 -- Mañana",
                "3 -- Jueves",
                "4 -- Otro dia"
            };

        }
    }
}
