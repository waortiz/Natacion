using Datos;
using Entidades;

namespace Negocio
{
    public class ControlDeportista : IControlDeportista
    {
        private IRepositorioDeportista repositorio;

        public ControlDeportista()
        {
            repositorio = new RepositorioDeportista();
        }

        public ControlDeportista(IRepositorioDeportista repositorio)
        {
            this.repositorio = repositorio;
        }

        public int IngresarDeportista(Deportista deportista)
        {
            return repositorio.IngresarDeportista(deportista);
        }
    }
}
