using Entidades;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioMaestro : IRepositorioMaestro
    {
        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            List<TipoDocumento> tiposDocumento = new List<TipoDocumento>
            {
                new TipoDocumento() { Id = 1, Nombre = "Cédula de Ciudadanía" },
                new TipoDocumento() { Id = 2, Nombre = "Tarjeta de Identidad" },
                new TipoDocumento() { Id = 3, Nombre = "Cédula de Extranjería" }
            };

            return tiposDocumento;
        }
    }
}
