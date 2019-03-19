using Datos;
using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public class ControlMaestro : IControlMaestro
    {
        private readonly IRepositorioMaestro repositorio;

        public ControlMaestro()
        {
            repositorio = new RepositorioMaestro();
        }

        public ControlMaestro(IRepositorioMaestro repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            return repositorio.ObtenerTiposDocumento();
        }
}
}
