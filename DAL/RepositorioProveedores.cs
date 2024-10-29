using System;
using ENTITY;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class RepositorioProveedores:BaseRepository<Proveedor>
    {
        public RepositorioProveedores( string FileName):base(FileName){ }

        public override List<Proveedor> GetAll()
        {
            List<Proveedor> ListaProveedor = new List<Proveedor>();
            try
            {

                StreamReader sr = new StreamReader(_fileName);
                while (!sr.EndOfStream)
                {
                    ListaProveedor.Add(Mapear(sr.ReadLine()));
                }
                sr.Close();
                return ListaProveedor;

            }
            catch (Exception)
            {

                return null;
            }
        }

        public Proveedor BuscarId(string id)
        {
            return GetAll().FirstOrDefault<Proveedor>(x => x.IDProveedor == id);
        }

        private Proveedor Mapear(string datos)
        {
            var linea = datos.Split(',');
            Proveedor proveedor = new Proveedor();
            {
                proveedor.IDProveedor = linea[0];
                proveedor.TipoID = linea[1];
                proveedor.Nombre = linea[2];
                proveedor.Telefono = double.Parse(linea[3]);
                proveedor.Email = linea[4];         
            };
            return proveedor;
        }
    }
}
