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
        }

        public Proveedor(string iDProveedor, TipoID tipoid, string nombre, string segundonombre, string apellido, string segundoapellido, double telefono, string email)
        {
            IDProveedor = iDProveedor;
            TipoID = tipoid;
            Nombre = nombre;
            SegundoNombre = segundonombre;
            Apellido = apellido;
            SegundoApellido = segundoapellido;
            Telefono = telefono;
            Email = email;          
        }

        public string IDProveedor { get; set; }
        public TipoID TipoID { get; set; }
        public string Nombre { get; set; }
        public string SegundoNombre { get; set; }
        public string Apellido { get; set; }
        public string SegundoApellido { get; set; }
        public double Telefono { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {         
            return $"{IDProveedor},{TipoID},{Nombre},{Telefono},{Email} ";

        }
    }
}

