using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public interface ILeer
    {
        public int Duracion { get; set; }
        public void LeerEnVozAlta();
    }
}