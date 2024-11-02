using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Productos
    {

        public Productos() { }

        public Productos(int iDProducto, string nombreProducto, decimal precioCompra, int cantidad, Categoria categoria)
        {
            IDProducto = iDProducto;
            NombreProducto = nombreProducto;
            PrecioCompra = precioCompra;
            Cantidad = cantidad;
            Categoria = categoria;
        }

        public int IDProducto { get; set; }
        public string NombreProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return $"{IDProducto},{NombreProducto},,{PrecioCompra},{Categoria.IDCategoria}";

        }

        public void ActualizarStock(int cantidad)
        {
            Cantidad += cantidad;
        }
    }
}
