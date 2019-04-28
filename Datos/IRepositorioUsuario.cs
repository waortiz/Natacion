using Entidades;

namespace Datos
{
    public interface IRepositorioUsuario
    {
        Usuario ConsultarUsuario(string nombreUsuario);
    }
}