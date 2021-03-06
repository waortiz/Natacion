﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;

namespace Negocio
{
    public class ControlDeportista : IControlDeportista
    {
        private IRepositorioDeportista repositorio;

        public ControlDeportista()
        {
            repositorio = new RepositorioDeportista();
        }

        public ControlDeportista(IRepositorioDeportista repositorio)
        {
            this.repositorio = repositorio;
        }

        public void IngresarDeportista(Deportista deportista)
        {
            repositorio.IngresarDeportista(deportista);
        }

        public DataTable ConsultarDeportistas()
        {
            return repositorio.ObtenerDeportistas();
        }

        public List<Deportista> ConsultarDeportistas(string numeroDocumento, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido)
        {
            return repositorio.ObtenerDeportistas(numeroDocumento, primerNombre, segundoNombre, primerApellido, segundoApellido);
        }

        public void EliminarDeportista(long idDeportista)
        {
            repositorio.EliminarDeportista(idDeportista);
        }

    }
}
