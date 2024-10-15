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
        public int IDFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public decimal TotalFactura  { get; set; }

        public override string ToString()
        {
            return $"Identificacion{IDFactura} Fecha de la factura:{FechaFactura} Total de la factura: {TotalFactura}";

        }
    }
}
