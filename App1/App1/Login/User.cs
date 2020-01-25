using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppInformeGranjas.Login
{
    class User
    {
        [PrimaryKey, MaxLength(20)]
        public int ID_CC { get; set; }
        [MaxLength(45)]
        public string Nombre { get; set; }
        [MaxLength(45)]
        public string Apellido { get; set; }
        [MaxLength(11)]
        public int usuario { get; set; }
        public User()
        {
        }
    }
}
