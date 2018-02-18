using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentacion.Web.Models.Respuestas
{
    public class RespuestaDeLogin
    {
        public string Token { get; set; }
        public bool FueExitosa { get; set; }
        public string Mensaje { get; set; }
    }
}