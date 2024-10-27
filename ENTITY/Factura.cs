using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Factura
    {
        public Factura()
        {
            Detalles = new List<DetalleFactura>();
        }
        public Factura(int idfactura, DateTime fechafactura, List<DetalleFactura> detalles)
        {
            IDFactura = idfactura;
            FechaFactura = fechafactura;
            Detalles = detalles ?? new List<DetalleFactura>();
            CalcularTotal();
        }

        public int IDFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal TotalFactura { get; private set; }
        public List<DetalleFactura> Detalles { get; set; }

        public void CalcularTotal()
        {
            TotalFactura = 0;
            foreach (var detalle in Detalles)
            {
                TotalFactura += detalle.Cantidad * detalle.PrecioUnitario;
            }
        }
        public override string ToString()
        {
            string detallesTexto = string.Join("\n", Detalles.Select(d => d.ToString()));
            return $"Identificación: {IDFactura}\n" +
                   $"Fecha de la factura: {FechaFactura}\n" +
                   $"Total de la factura: {TotalFactura:C}\n" +
                   $"Detalles:\n{detallesTexto}";
        }
    }
}
