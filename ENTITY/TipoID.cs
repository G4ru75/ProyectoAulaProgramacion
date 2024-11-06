using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class TipoID
    {

        public TipoID () { }


        public TipoID (string codigoid, string nombre ) 
        {
            CodigoID = codigoid;
            Nombre = nombre;
        }

        public string CodigoID { get; set; }
        public string Nombre { get; set; }
    }
}
