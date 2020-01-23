using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppInformeGranjas.Models
{
    public interface ISQLiteInterface
    {
        SQLiteConnection GetSQLiteConnection();
    }
}
