namespace AppInformeGranjas.Controller
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using SQLite;
    [Table("tb_detalles")]
    public class tb_detalles
    {
        [PrimaryKey, MaxLength(20), AutoIncrement]
        public int Id_detalle { get; set; }

        public DateTime fecha { get; set; }

        [MaxLength(11)]
        public int granja { get; set; }
        [MaxLength(11)]
        public int galpon { get; set; }
        [MaxLength(15)]
        public int galponero { get; set; }
        [MaxLength(11)]
        public int mortalidad { get; set; }

        [MaxLength(11)]
        public decimal alimento { get; set; }
        [MaxLength(11)]
        public decimal peso { get; set; }

        [MaxLength(11)]
        public int veterinario { get; set; }
    }

}
