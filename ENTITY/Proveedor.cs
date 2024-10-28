using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Proveedor
    {
        public Proveedor()
        {
            Producto = new List<Productos>(); 
        }

        public Proveedor(string iDProveedor, string tipoID, string nombre, double telefono, string email, List<Productos> producto)
        {
            IDProveedor = iDProveedor;
            TipoID = tipoID;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            Producto = producto ?? new List<Productos>(); 
        }

        public string IDProveedor { get; set; }
        public string TipoID { get; set; }
        public string Nombre { get; set; }
        public double Telefono { get; set; }
        public string Email { get; set; }
        public List<Productos> Producto { get; set; }

        public override string ToString()
        {         
            return $"{TipoID},{IDProveedor},{Nombre},{Telefono},{Email} ";

        }

        public void AgregarProducto(Productos producto)
        {
            if (!Producto.Contains(producto))
            {
                Producto.Add(producto);
            }
        }

        public void EliminarProducto(Productos producto)
        {
            if (Producto.Contains(producto))
            {
                Producto.Remove(producto);
            }
        }
    }
}

