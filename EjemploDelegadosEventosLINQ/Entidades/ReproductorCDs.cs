using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    public class ReproductorCDs
    {
        public bool ProbarCd()
        {
            Console.WriteLine("Por favor, ponga el cd en el reproductor");
            Console.WriteLine("Pulsa el botón de reproducción");
            Console.WriteLine("Indique a continuación si ha escuchado algo");

            var result = Console.ReadLine();

            return result.ToUpper().Equals("S");
        }

        public List<string> MostrarListaCanciones() 
        {

            return new List<string>
            {
                "Mama mia",
                "Volvere",
                "Mañana",
                "Jueves",
                "Otro dia"
            };
        }

    }
}
