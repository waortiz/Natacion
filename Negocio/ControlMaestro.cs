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
            repositorio = new RepositorioMaestroMock();
        }

        public ControlMaestro(IRepositorioMaestro repositorio)
        {
            this.repositorio = repositorio;
        }

        public List<Disciplina> ObtenerDisciplinas()
        {
            return repositorio.ObtenerDisciplinas();
        }

        public List<EPS> ObtenerEPS()
        {
            return repositorio.ObtenerEPS();
        }

        public List<Sexo> ObtenerSexo()
        {
            return repositorio.ObtenerSexo();
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            return repositorio.ObtenerTiposDocumento();
        }
}
}
