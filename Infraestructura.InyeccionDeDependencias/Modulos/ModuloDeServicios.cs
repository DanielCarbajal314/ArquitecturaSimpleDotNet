using Autofac;
using Servicios.Implementacion.Logistica.ManejoDePaquetes;
using Servicios.Implementacion.Seguridad;
using Servicios.Interfaces.Logistica.ManejoDePaquetes;
using Servicios.Interfaces.Seguridad.Token;
using Servicios.Interfaces.Seguridad.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.InyeccionDeDependencias.Modulos
{
    public class ModuloDeServicios:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Autofac
            //Autofac.WepApi2
            //Autofac.Mvc5

            builder.RegisterType<GestorDePaquetes>().As<IGestorDePaquetes>().InstancePerLifetimeScope(); ;
            builder.RegisterType<GestorDeUsuarios>().As<IGestorDeUsuarios>().InstancePerLifetimeScope(); ;
            builder.RegisterType<GestorDeToken>().As<IGestorDeToken>().InstancePerLifetimeScope(); ;
        }
    }
}
