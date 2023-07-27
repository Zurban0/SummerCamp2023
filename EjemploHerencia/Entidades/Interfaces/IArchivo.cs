using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public interface IArchivo
    {
        public string NombreArchivo { get; set; }

        public void Escribir();
        public string Leer();
    }
}