using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia
{
    internal class ErrorBaseDatosException : Exception
    {
        public ErrorBaseDatosException(string mensaje, DateTime ferchaHora) : base(mensaje)
        {
            FechaHora = ferchaHora;
        }
        public DateTime FechaHora { get; set; }
    }
}
