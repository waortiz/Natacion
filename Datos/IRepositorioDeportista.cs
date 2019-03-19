using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IRepositorioDeportista
    {
        int IngresarDeportista(Deportista deportista);
    }
}
