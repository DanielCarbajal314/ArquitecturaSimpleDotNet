using Presentacion.Web.ActionFilters;
using Presentacion.Web.Models.Respuestas;
using Servicios.Implementacion.Seguridad;
using Servicios.Interfaces.Seguridad.Token;
using Servicios.Interfaces.Seguridad.User;
using Servicios.Interfaces.Seguridad.User.Peticion;
using Servicios.Interfaces.Seguridad.User.Respuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentacion.Web.Controllers.API
{
    public class SeguridadController : ApiController
    {
        IGestorDeUsuarios _gestorDeUsuarios;
        IGestorDeToken _gestorDeToken;

        public SeguridadController(IGestorDeUsuarios gestorDeUsuarios, IGestorDeToken gestorDeToken)
        {
            this._gestorDeUsuarios = gestorDeUsuarios;
            this._gestorDeToken = gestorDeToken;
        }

        [HttpPost]
        public RespuestaDeLogin Identificarce(IntentoDeLogin intentoDeLogin)
        {
            RespuestaDeLogin respuestaDeLogin = new RespuestaDeLogin();
            Usuario usuario = _gestorDeUsuarios.Login(intentoDeLogin);
            if (usuario == null)
            {
                respuestaDeLogin.FueExitosa = false;
                respuestaDeLogin.Mensaje = "Las credenciales son incorrectas";
            }
            else
            {
                respuestaDeLogin.FueExitosa = true;
                respuestaDeLogin.Token = this._gestorDeToken.GenerarToken(usuario);
            }
            return respuestaDeLogin;
        }

        [HttpGet]
        [RequiereAutenticacion]
        public Usuario CorroborarCredenciales()
        {
            return ActionContext.CargarUsuario();
        }

    }
}
