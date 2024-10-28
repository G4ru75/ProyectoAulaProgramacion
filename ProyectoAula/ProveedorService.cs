using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAula
{
    public class ProveedorService
    {
        RepositorioProveedores Repositorio;
        public event Action<Proveedor> ProveedorGuardado;
        private List<Proveedor> proveedor;
        public  ProveedorService()
        {
            Repositorio = new RepositorioProveedores(Config.Filename_Prove);
            RefrescarLista();
        }
        void RefrescarLista()
        {
            proveedor = Repositorio.GetAll();
        }
        public string Guardar(Proveedor proveedor)
        {
            var msg = Repositorio.SaveData(proveedor);
            RefrescarLista();
            ProveedorGuardado?.Invoke(proveedor);
            return msg;
        }
        public List<Proveedor> Consultar()
        {
            return proveedor;
        }

        public Proveedor BuscarId(string id)
        {
            var prove = proveedor.FirstOrDefault<Proveedor>(x => x.IDProveedor == id);
            return prove;
        }
    }
}
