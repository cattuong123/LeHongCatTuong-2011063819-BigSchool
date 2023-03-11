namespace Lê_Hồng_Cát_Tường_2011063819.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("categoriess")]
    public partial class categoriess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public categoriess()
        {
            Coursesses = new HashSet<Coursess>();
        }

        [Key]
        [StringLength(50)]
        public string Categori { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Coursess> Coursesses { get; set; }
    }
}
