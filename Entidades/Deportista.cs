using System;

namespace Entidades
{
    public class Deportista
    {
        public int Id { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public Disciplina Disciplina { get; set; }
        public EPS EPS { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NombreTipoDocumento
        {
            get
            {
                if (TipoDocumento != null)
                {
                    return TipoDocumento.Nombre;
                }

                return string.Empty;
            }
        }
    }
}
