using Entidades;
using System.Collections.Generic;

namespace Datos
{
    public interface IRepositorioMaestro
    {
        List<TipoDocumento> ObtenerTiposDocumento();
        List<EPS> ObtenerEPS();
        List<Disciplina> ObtenerDisciplinas();
        List<Sexo> ObtenerSexo();
    }
}
