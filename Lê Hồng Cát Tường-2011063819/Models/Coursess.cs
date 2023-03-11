namespace Lê_Hồng_Cát_Tường_2011063819.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Coursess")]
    public partial class Coursess
    {
        [Key]
        [StringLength(100)]
        public string place { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        [StringLength(100)]
        public string time { get; set; }

        [StringLength(50)]
        public string Categori { get; set; }

        public virtual categoriess categoriess { get; set; }
    }
}
