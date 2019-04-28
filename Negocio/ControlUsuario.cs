using Datos;
using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public class ControlUsuario : IControlUsuario
    {
        private IRepositorioUsuario repositorio;

        public ControlUsuario()
        {
            repositorio = new RepositorioUsuarioMock();
        }

        public ControlUsuario(IRepositorioUsuario repositorio)
        {
            this.repositorio = repositorio;
        }

        public Usuario ConsultarUsuario(string nombreUsuario)
        {
            return repositorio.ConsultarUsuario(nombreUsuario);
        }
        public bool VerificarUsuario(string nombreUsuario, string clave)
        {
            bool resultado = false;
            Usuario usuario = repositorio.ConsultarUsuario(nombreUsuario);
            if (usuario != null)
            {
                resultado = (usuario.Clave == clave);
            }
            return resultado;
        }

    }
}
