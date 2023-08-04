using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EjemploLinq
{
    public class EjemploBasico
    {
        public void Ejecutar()
        {
            string[] niveles = { "Basico", "Intermedio", "Avanzado" };
            int nc = niveles.Count();

            //Selecciona todos los niveles cuaya longitud en carácteres sea mayor que 6 ordenado por nombre

            List<string> resultaodFinalNiveles = new();
            foreach (var nivel in niveles)
            {
                if (nivel.Length > 6)
                {

                }
            }

            //Sintaxis sql.
            //SELECT nivel FROM niveles
            //order by nivel

            resultaodFinalNiveles = (from nivel in niveles
                                     where nivel.Length > 6
                                     orderby nivel
                                     select nivel).ToList();


            //Sintaxis de métodos
            //1. Preparación
            Func<string, bool> predicado = nivel => nivel.Length > 6;
            resultaodFinalNiveles = niveles.Where(predicado).OrderBy(n => n).ToList();
        }
    }

    
}
