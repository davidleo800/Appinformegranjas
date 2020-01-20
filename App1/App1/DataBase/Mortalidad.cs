using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppInformeGranjas.DataBase
{
    public class Mortalidad
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Fecha { get; set; }
        public int Mort { get; set; }
    }
}
