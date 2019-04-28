using Entidades;

namespace Negocio
{
    public interface IControlUsuario
    {
        Usuario ConsultarUsuario(string nombreUsuario);

        bool VerificarUsuario(string nombreUsuario, string clave);
    }
}