using Servicios.Interfaces.Logistica.ManejoDePaquetes.Peticion;
using Servicios.Interfaces.Logistica.ManejoDePaquetes.Respuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicios.Interfaces.Compartido;

namespace Servicios.Interfaces.Logistica.ManejoDePaquetes
{
    public interface IGestorDePaquetes: IMantenimientoBase<PaqueteNuevo, PaqueteParaActualizar, PaqueteRegistrado>
    {
    }
}
