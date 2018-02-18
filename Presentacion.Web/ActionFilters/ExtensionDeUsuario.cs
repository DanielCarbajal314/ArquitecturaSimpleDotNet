using Servicios.Interfaces.Seguridad.User.Respuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;

namespace Presentacion.Web.ActionFilters
{
    public static class ExtensionDeUsuario
    {
        private static readonly string USER_DATA_KEY = "DatosDelUsuario";

        public static void GuardarEnHttpContext(this Usuario usuario, HttpActionContext actionContext)
        {
            actionContext.Request.Properties.Add(USER_DATA_KEY, usuario);
        }

        public static Usuario CargarUsuario(this HttpActionContext actionContext)
        {
            return (Usuario)actionContext.Request.Properties[USER_DATA_KEY];
        }
    }
}