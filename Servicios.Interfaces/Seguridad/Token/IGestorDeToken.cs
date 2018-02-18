using Servicios.Interfaces.Seguridad.User.Respuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Seguridad.Token
{
    public interface IGestorDeToken
    {
        string GenerarToken(Usuario usuario);
        Usuario RecuperarInformacionDeUsuario(string token);
    }
}
