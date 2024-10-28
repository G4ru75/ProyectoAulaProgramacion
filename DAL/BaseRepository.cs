using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    public abstract class BaseRepository<T>
    {
        protected string _fileName;
        protected BaseRepository(string filename)
        {
            _fileName = filename;
        }
        public abstract List<T> GetAll();
        public string SaveData(T entidad)
        {
            try
            {
                StreamWriter writer = new StreamWriter(_fileName, true);
                writer.WriteLine(entidad.ToString());
                writer.Close();
                return "Datos Guardados correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }
}
