using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDelegados
{
    public class Tocadiscos
    {
        public bool ProbarTocadiscos()
        {
            Console.WriteLine("Por favor, ponga el cd en el reproductor");
            Console.WriteLine("Pulsa el botón de reproducción");
            Console.WriteLine("Indique a continuación si ha escuchado algo");

            var result = Console.ReadLine();

            return result.ToUpper().Equals("S");
        }

        public List<string> MostrarInformacionCancion()
        {

            return new List<string>
            {
                "INFORMACIÓN DE LA CANCIÓN",
                "asdasdasd",
                "asdasd",
                "asdasd"
            };

        }
    }
}
