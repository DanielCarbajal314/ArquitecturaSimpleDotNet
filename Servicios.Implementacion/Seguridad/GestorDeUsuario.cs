using Servicios.Interfaces.Seguridad.User;
using Servicios.Interfaces.Seguridad.User.Peticion;
using Servicios.Interfaces.Seguridad.User.Respuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Implementacion.Seguridad
{
    public class GestorDeUsuarios : IGestorDeUsuarios
    {
        public Usuario Login(IntentoDeLogin intentoDeLogin)
        {
            Usuario usuario = new Usuario()
            {
                Email = "daniel.carbajal@pucp.edu.pe",
                Nombre = intentoDeLogin.NombreDeUsuario,
                NombreUsuario = "dcarbajal",
                PermisosDeSeguridad = new List<PermisoDeSeguridad>(new PermisoDeSeguridad[] { PermisoDeSeguridad.Administrador })
            };
            return usuario;
        }

    }
}
