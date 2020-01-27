namespace AppInformeGranjas.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using SQLite;

    [Table("tb_login")]
    public class tb_login
    {
        [PrimaryKey, MaxLength(20)]
        public int ID_CC { get; set; }
        [MaxLength(45)]
        public string Nombre { get; set; }
        [MaxLength(45)]
        public string Apellido { get; set; }
        [MaxLength(11)]
        public int usuario { get; set; }

        public tb_login() { }
    }
}
