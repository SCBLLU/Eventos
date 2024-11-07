using Eventos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos.Clases
{
    internal class CRUDFacturas
    {
        public void CrearFactura(Factura f)
        {
            using (var bd = new EventosContext())
            {
                bd.Facturas.Add(f);
                bd.SaveChanges();
            }
        }

        public void EliminarFactura(Factura f)
        {
            using (var bd = new EventosContext())
            {
                var factura = bd.Facturas.Find(f.FacturaId);
                bd.Facturas.Remove(factura);
                bd.SaveChanges();
            }
        }

        public void ActualizarFactura(Factura f)
        {
            using (var bd = new EventosContext())
            {
                var factura = bd.Facturas.Find(f.FacturaId);
                factura.FechaFactura = f.FechaFactura;
                factura.MontoTotal = f.MontoTotal;
                factura.Estado = f.Estado;
                bd.SaveChanges();
            }
        }
    }
}
