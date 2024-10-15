using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class DetalleFactura
    {
        public int IDDetalle {  get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario {  get; set; }
        public decimal Total {  get; set; }

        public override string ToString()
        {
            return $"ID: {IDDetalle} Cantidad: {Cantidad} Precio unitario: {PrecioUnitario} Total: {Total}";
        }
    }
}
