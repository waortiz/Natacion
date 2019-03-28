using Entidades;
using System.Collections.Generic;

namespace Datos
{
    public interface IRepositorioDeportista
    {
        int IngresarDeportista(Deportista deportista);
        List<Deportista> ObtenerDeportistas(string numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido);
        void EliminarDeportista(long idDeportista);
    }
}
