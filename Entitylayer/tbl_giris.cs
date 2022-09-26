namespace Entitylayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_giris
    {
        [Key]
        public int kullaniciid { get; set; }

        [StringLength(50)]
        public string kullaniciadi { get; set; }

        [StringLength(50)]
        public string sifre { get; set; }
    }
}
