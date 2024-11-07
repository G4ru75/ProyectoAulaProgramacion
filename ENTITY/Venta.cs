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
        public DetalleFactura() { }

        public DetalleFactura(Productos productos, int cantidad, decimal preciounitario) 
        {
            Productos = productos;
            Cantidad = cantidad;
            PrecioUnitario = preciounitario; 
        }
        public Productos Productos { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario {  get; set; }

        public override string ToString()
        {
            return $"{Productos.NombreProducto},{Cantidad},{PrecioUnitario}";
        }
    }
}
