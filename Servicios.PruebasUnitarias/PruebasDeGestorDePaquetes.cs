using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Infraestructura.Transformaciones;
using Servicios.Interfaces.Logistica.ManejoDePaquetes.Peticion;
using Servicios.Implementacion.Logistica.ManejoDePaquetes;
using Servicios.Interfaces.Logistica.ManejoDePaquetes.Respuesta;

namespace Servicios.PruebasUnitarias
{
    [TestClass]
    public class PruebasDeGestorDePaquetes
    {
        [TestInitialize]
        public void InicializarEscenarioDePruebas()
        {
            Configurador.InicializarMapas();
        }

        [TestMethod]
        public void RegistrarPaquete()
        {
            PaqueteNuevo nuevoPaquete = new PaqueteNuevo();
            nuevoPaquete.Contenido = "Frutas";
            nuevoPaquete.Destino = "Lima";
            nuevoPaquete.Remitente = "Daniel";
            GestorDePaquetes gestorDePaquetes = new GestorDePaquetes();
            PaqueteRegistrado paqueteRegistrado = gestorDePaquetes.Registrar(nuevoPaquete);
            bool paqueteRegistradoConIdMayorQueUno = paqueteRegistrado.Id > 0;
            Assert.AreEqual(paqueteRegistradoConIdMayorQueUno, true);
        }
    }
}
