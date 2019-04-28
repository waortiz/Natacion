using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Datos
{
    public class RepositorioUsuarioMock : IRepositorioUsuario
    {
        public Usuario ConsultarUsuario(string nombreUsuario)
        {
            Usuario usuario = null;

            if(nombreUsuario == "wortiz")
            {
                usuario = new Usuario()
                {
                    Clave = "123",
                    Nombre = "William Ortiz"
                };
            }

            return usuario;
        }
    }
}
