using Entidades;
using System.Collections.Generic;

namespace Datos
{
    public class RepositorioMaestroMock : IRepositorioMaestro
    {
        public List<Disciplina> ObtenerDisciplinas()
        {
            var disciplinas = new List<Disciplina>
            {
                new Disciplina() { Id = 1, Nombre = "Libre" },
                new Disciplina() { Id = 2, Nombre = "Mariposa" },
            };

            return disciplinas;
        }

        public List<EPS> ObtenerEPS()
        {
            var eps = new List<EPS>
            {
                new EPS() { Id = 1, Nombre = "SURA" },
                new EPS() { Id = 2, Nombre = "SALUD TOTAL" },
                new EPS() { Id = 3, Nombre = "COOMEVA" }
            };

            return eps;
        }

        public List<Sexo> ObtenerSexo()
        {
            var sexo = new List<Sexo>
            {
                new Sexo() { Id = 1, Nombre = "Masculino" },
                new Sexo() { Id = 2, Nombre = "Femenino" },
            };

            return sexo;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = new List<TipoDocumento>
            {
                new TipoDocumento() { Id = 1, Nombre = "Cédula de Ciudadanía" },
                new TipoDocumento() { Id = 2, Nombre = "Tarjeta de Identidad" },
                new TipoDocumento() { Id = 3, Nombre = "Cédula de Extranjería" }
            };

            return tiposDocumento;
        }
    }
}
