using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Seguridad.User.Respuesta
{
    public class Usuario
    {
        public string Email { get; set; }
        public string Nombre { get; set; }
        public string NombreUsuario { get; set; }
        public List<PermisoDeSeguridad> PermisosDeSeguridad { get; set; }
    }
}
