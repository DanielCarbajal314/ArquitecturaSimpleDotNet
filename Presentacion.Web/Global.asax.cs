using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using Infraestructura.InyeccionDeDependencias;
using Infraestructura.InyeccionDeDependencias.Modulos;
using Infraestructura.Transformaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Presentacion.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Configurador.InicializarMapas();
            this.ConfigurarInyeccion();



            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigurarInyeccion()
        {
            var constructor = new ContainerBuilder();
            var configuracion = GlobalConfiguration.Configuration;
            constructor.RegisterApiControllers(Assembly.GetExecutingAssembly());
            constructor.RegisterWebApiFilterProvider(configuracion);
            constructor.RegisterWebApiModelBinderProvider();
            
            constructor.RegisterModule<ModuloDeServicios>();

            var contenedor = constructor.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(contenedor));
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(contenedor);
        }
    }
}
