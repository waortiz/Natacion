﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public interface IControlDeportista
    {
        int IngresarDeportista(Deportista deportista);
    }
}
