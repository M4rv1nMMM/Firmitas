using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firma.Models;
using SQLite;

namespace Firma.Controllers
{
    public class BaseDatosSQLite
    {
        readonly SQLiteAsyncConnection db;

        //Constructor de la clase DataBaseSQLite
        public BaseDatosSQLite(String pathdb)
        {
            //Crear una conexion a la base de datos
            db = new SQLiteAsyncConnection(pathdb);

            //Creacion de la tabla personas dentro de SQLite
            db.CreateTableAsync<ModelFirmas>().Wait();
        }

        // Operaciones CRUD con SQLite
        //READ List Way
        public Task<List<ModelFirmas>> ObtenerListaFirmas()
        {
            return db.Table<ModelFirmas>().ToListAsync();
        }

        //READ one by one
        public Task<ModelFirmas> GetFirma(int pid)
        {
            return db.Table<ModelFirmas>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }

        //CREATE firma
        public Task<int> SaveFirma(ModelFirmas sing)
        {
            if (sing.id != 0)
            {
                return db.UpdateAsync(sing);
            }
            else
            {
                return db.InsertAsync(sing);
            }
        }

        //Delete

        public Task<int> DeleteFirma(ModelFirmas sing)
        {
            return db.DeleteAsync(sing);

        }
    }
}
