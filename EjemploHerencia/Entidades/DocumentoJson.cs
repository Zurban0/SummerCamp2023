using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class DocumentoJson : IArchivosJson
    {
        public string NombreArchivo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Deserializar()
        {
            //TODO: 
            throw new NotImplementedException();
        }

        public void Escribir()
        {
            throw new NotImplementedException();
        }

        public string Leer()
        {
            throw new NotImplementedException();
        }

        public void Serializar()
        {
            throw new NotImplementedException();
        }
    }
}