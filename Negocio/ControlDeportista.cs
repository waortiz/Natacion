using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ControlDeportista
    {
        private RepositorioDeportista repositorio;

        public ControlDeportista()
        {
            repositorio = new RepositorioDeportista();
        }

        public int IngresarDeportista(Deportista deportista)
        {
            return repositorio.IngresarDeportista(deportista);
        }
    }
}
