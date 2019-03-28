using Entidades;
using System.Collections.Generic;

namespace Datos
{
    public interface IRepositorioMaestro
    {
        List<TipoDocumento> ObtenerTiposDocumento();
    }
}
