using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        public Usuario()
        {
        }

        public Usuario(string nombre, string clave)
        {
            this.Nombre = nombre;
            this.Clave = clave;
        }

        public string Nombre { get; set; }
        public string Clave { get; set; }
    }
}
