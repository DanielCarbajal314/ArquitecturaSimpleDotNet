using System;
using System.Linq;
using Dominio.Contextos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dominio.PruebasUnitarias
{
    [TestClass]
    public class PruebaDePaquete
    {
        [TestMethod]
        public void CreacionDeBaseDeDatos()
        {
            new LogisticaBD().Paquetes.ToList();
        }
    }
}
