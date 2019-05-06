using Entidades;
using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public interface IRepositorioDeportista
    {
        void IngresarDeportista(Deportista deportista);
        List<Deportista> ObtenerDeportistas(string numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido);
        void EliminarDeportista(long idDeportista);
        DataTable ObtenerDeportistas();
    }
}
