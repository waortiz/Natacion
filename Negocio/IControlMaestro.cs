using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public interface IControlMaestro
    {
        List<TipoDocumento> ObtenerTiposDocumento();
        List<EPS> ObtenerEPS();
        List<Disciplina> ObtenerDisciplinas();
        List<Sexo> ObtenerSexo();
    }
}
