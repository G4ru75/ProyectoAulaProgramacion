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

        public Productos(int iDProducto, string nombreProducto, string descripcion, decimal precioCompra, int cantidad, Categoria categoria)
        {
            IDProducto = iDProducto;
            NombreProducto = nombreProducto;
            Descripcion = descripcion;
            PrecioCompra = precioCompra;
            Cantidad = cantidad;
            Categoria = categoria;
        }

        public int IDProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public int Cantidad { get; set; }
        public Categoria Categoria { get; set; }

        public override string ToString()
        {
            return $"Identificacion{IDProducto} Nombre:{NombreProducto} Descripcion: {Descripcion} Precio: {PrecioCompra} Categoria: {Categoria.IDCategoria}";

        }

        public void ActualizarStock(int cantidad)
        {
            Cantidad += cantidad;
        }
    }
}
