using Datos;
using Entidades;
using System.Collections.Generic;

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

        public List<Deportista> ConsultarDeportistas(string numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            return repositorio.ObtenerDeportistas(numeroDocumento, primerNombre, segundoNombre, primerApellido, segundoApellido);
        }

        public void EliminarDeportista(long idDeportista)
        {
            repositorio.EliminarDeportista(idDeportista);
        }

    }
}
