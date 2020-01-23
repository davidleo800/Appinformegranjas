using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppInformeGranjas.Models;
using SQLite;


namespace App1.Droid
{
    public class ISQLiteDbInterface_Android : ISQLiteInterface
    {
        public SQLiteConnection GetSQLiteConnection()
        {
            throw new NotImplementedException();
        }
    }
}