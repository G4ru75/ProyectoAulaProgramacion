using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Proveedor
    {
        
        public int IDProveedor { get; set; }
        public string TipoID { get; set; }
        public string Nombre { get; set; }
        public double Telefono { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Tipo de identificacion: {TipoID} Identificacion{IDProveedor} Nombre:{Nombre} Telefono: {Telefono} Email: {Email}";

        }
    }
}

