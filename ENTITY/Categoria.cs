using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Categoria
    {
        public Categoria() { }

        public Categoria(int idcategoria, string nombrecategoria, string descripcion)
        {
            IDCategoria = idcategoria;
            NombreCategoria = nombrecategoria;
            Descripcion = descripcion; 
        }

        public int IDCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return $",{IDCategoria},{NombreCategoria},{Descripcion}"; 
        }
    }
}
