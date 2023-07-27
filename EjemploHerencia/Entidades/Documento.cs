using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Documento : IArchivo
    {
        public string NombreArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Escribir()
        {
            throw new NotImplementedException();
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }
    }
}