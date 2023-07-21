using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Empresa
    {
        public Empresa(string nombre) 
        {
            Nombre = nombre;        
        }
        public string Nombre { get; set; }
    }
}