using AutoMapper;
using Dominio.Entidades.Logistica;
using Servicios.Interfaces.Logistica.ManejoDePaquetes.Peticion;
using Servicios.Interfaces.Logistica.ManejoDePaquetes.Respuesta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Transformaciones
{
    public static class Configurador
    {
        public static void InicializarMapas()
        {
            Mapper.Initialize(configuration => {
                configuration.CreateMap<Paquete, PaqueteNuevo>();
                configuration.CreateMap<PaqueteNuevo, Paquete>();
                configuration.CreateMap<PaqueteRegistrado, Paquete>();
                configuration.CreateMap<Paquete, PaqueteRegistrado>();
            });
        }
    }
}
