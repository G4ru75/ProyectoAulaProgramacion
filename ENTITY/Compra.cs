namespace ENTITY
{
    public class Compra
    {

        public Compra() { }

        public Compra(int idcompra, Proveedor proveedor, Productos productos, int cantidad, decimal preciocompra)
        {
            IDCompra = idcompra;
            Proveedor = proveedor;
            Productos = productos;
            Cantidad = Cantidad;
            PrecioCompra = PrecioCompra;
        }

        public int IDCompra { get; set; }
        public Proveedor Proveedor { get; set; }
        public Productos Productos { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompra { get; set; }

        public override string ToString()
        {
            return $"{IDCompra},{Proveedor.IDProveedor},{Productos.IDProducto},{Cantidad},{PrecioCompra}"; 
        }
    }
}
