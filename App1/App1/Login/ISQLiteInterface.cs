using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppInformeGranjas.Login
{
    interface ISQLiteInterface
    {
        SQLiteConnection GetSQLiteConnection();
    }
}
