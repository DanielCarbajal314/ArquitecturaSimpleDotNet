using Servicios.Interfaces.Seguridad.User.Peticion;
using Servicios.Interfaces.Seguridad.User.Respuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Seguridad.User
{
    public interface IGestorDeUsuarios
    {
        Usuario Login(IntentoDeLogin intentoDeLogin);
    }
}
