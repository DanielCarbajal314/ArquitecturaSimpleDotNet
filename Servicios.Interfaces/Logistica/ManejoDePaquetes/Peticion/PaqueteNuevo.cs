using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Interfaces.Logistica.ManejoDePaquetes.Peticion
{
    public class PaqueteNuevo
    {
        public string Remitente { get; set; }
        public string Destino { get; set; }
        public string Contenido { get; set; }
    }
}
