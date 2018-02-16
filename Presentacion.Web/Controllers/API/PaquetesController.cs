using Servicios.Implementacion.Logistica.ManejoDePaquetes;
using Servicios.Interfaces.Logistica.ManejoDePaquetes;
using Servicios.Interfaces.Logistica.ManejoDePaquetes.Peticion;
using Servicios.Interfaces.Logistica.ManejoDePaquetes.Respuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentacion.Web.Controllers.API
{
    public class PaquetesController : ApiController
    {

        IGestorDePaquetes _gestorDePaquetes;

        public PaquetesController()
        {
            this._gestorDePaquetes = new GestorDePaquetes();
        }

        [HttpPut]
        public PaqueteRegistrado Actualizar(PaqueteParaActualizar registroParaActualizar)
        {
            return this._gestorDePaquetes.Actualizar(registroParaActualizar);
        }

        [HttpPut]
        public void Borrar(int IdDelRegistro)
        {
            this._gestorDePaquetes.Borrar(IdDelRegistro);
        }

        [HttpGet]
        public List<PaqueteRegistrado> Listar()
        {
            return this._gestorDePaquetes.Listar();
        }

        [HttpPost]
        public PaqueteRegistrado Registrar(PaqueteNuevo registroNuevo)
        {
            return this._gestorDePaquetes.Registrar(registroNuevo);
        }
    }
}
