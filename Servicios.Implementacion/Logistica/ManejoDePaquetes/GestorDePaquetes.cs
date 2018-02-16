using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Dominio.Contextos;
using Dominio.Entidades.Logistica;
using Servicios.Interfaces.Logistica.ManejoDePaquetes;
using Servicios.Interfaces.Logistica.ManejoDePaquetes.Peticion;
using Servicios.Interfaces.Logistica.ManejoDePaquetes.Respuesta;

namespace Servicios.Implementacion.Logistica.ManejoDePaquetes
{
    public class GestorDePaquetes : IGestorDePaquetes
    {
        public PaqueteRegistrado Actualizar(PaqueteParaActualizar registroParaActualizar)
        {
            using (LogisticaBD db = new LogisticaBD())
            {
                Paquete nuevoPaquete = db.Paquetes.Find(registroParaActualizar.Id);
                nuevoPaquete.Destino = registroParaActualizar.Destino;
                nuevoPaquete.Remitente = registroParaActualizar.Remitente;
                db.Entry(nuevoPaquete).Property(x => x.Destino).IsModified = true;
                db.Entry(nuevoPaquete).Property(x => x.Remitente).IsModified = true;
                db.SaveChanges();
                return Mapper.Map<PaqueteRegistrado>(nuevoPaquete);
            }
        }

        public void Borrar(int IdDelRegistro)
        {
            using (LogisticaBD db = new LogisticaBD())
            {
                Paquete paquete = new Paquete()
                {
                    Id = IdDelRegistro,
                    FueBorrado = true
                };
                db.Paquetes.Attach(paquete);
                db.Entry(paquete).Property(x => x.FueBorrado).IsModified = true;
                db.SaveChanges();
            }
        }

        public List<PaqueteRegistrado> Listar()
        {
            using (LogisticaBD db = new LogisticaBD())
            {
                return db.Paquetes.ToList().Select(x => Mapper.Map<PaqueteRegistrado>(x)).ToList();
            }
        }

        public PaqueteRegistrado Registrar(PaqueteNuevo registroNuevo)
        {
            Paquete nuevoPaquete = Mapper.Map<Paquete>(registroNuevo);
            using (LogisticaBD db = new LogisticaBD())
            {
                db.Paquetes.Add(nuevoPaquete);
                db.SaveChanges();
            }
            return Mapper.Map<PaqueteRegistrado>(nuevoPaquete);
        }
    }
}
