using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Seguridad.User.Peticion
{
    public class IntentoDeLogin
    {
        public string NombreDeUsuario { get; set; }
        public string Password { get; set; }
    }
}
