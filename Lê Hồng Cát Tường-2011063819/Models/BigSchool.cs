using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Lê_Hồng_Cát_Tường_2011063819.Models
{
    public partial class BigSchool : DbContext
    {
        public BigSchool()
            : base("name=BigSchool")
        {
        }

        public virtual DbSet<categoriess> categoriesses { get; set; }
        public virtual DbSet<Coursess> categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<categoriess>()
                .Property(e => e.Categori)
                .IsUnicode(false);

            modelBuilder.Entity<Coursess>()
                .Property(e => e.place)
                .IsUnicode(false);

            modelBuilder.Entity<Coursess>()
                .Property(e => e.time)
                .IsUnicode(false);

            modelBuilder.Entity<Coursess>()
                .Property(e => e.Categori)
                .IsUnicode(false);
        }
    }
}
