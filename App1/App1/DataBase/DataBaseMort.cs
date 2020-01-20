using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace AppInformeGranjas.DataBase
{
    public class DataBaseMort
    {
        readonly SQLiteAsyncConnection _database;

        public DataBaseMort(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Mortalidad>().Wait();
        }

        public Task<List<Mortalidad>> GetPeopleAsync()
        {
            return _database.Table<Mortalidad>().ToListAsync();
        }

        public Task<int> SavePersonAsync(Mortalidad mortalidad)
        {
            return _database.InsertAsync(mortalidad);
        }
    }
}
