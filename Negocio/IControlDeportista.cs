using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public interface IControlDeportista
    {
        void IngresarDeportista(Deportista deportista);
        List<Deportista> ConsultarDeportistas(string numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido);
        void EliminarDeportista(long idDeportista);
    }
}
