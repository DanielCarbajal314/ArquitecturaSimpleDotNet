using Dominio.Entidades.Logistica;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Contextos
{
    public class LogisticaBD : DbContext
    {
        private static readonly string NOMBRE_CADENA_CONEXION = "Logistica";

        public LogisticaBD() : base(NOMBRE_CADENA_CONEXION) { }

        public DbSet<Paquete> Paquetes { get; set; }
    }
}
