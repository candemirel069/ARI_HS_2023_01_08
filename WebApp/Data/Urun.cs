using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
    }

    public class Kategori:BaseEntity
    {
        public string Adi { get; set; }
        
        public virtual List<Urun> Urunler { get; set; }
    }

    public class Urun : BaseEntity
    {
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public int SeriNo { get; set; }

        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }
    }

   public class UrunContext:DbContext
    {
        public UrunContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Urun> Urunler{ get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { Id=1  , Adi = "Ram" },
                new Kategori { Id=2  , Adi = "Hdd" },
                new Kategori { Id=3  , Adi = "Cpu" },
                new Kategori { Id=4  , Adi = "Ssd" });
        }
    }
}
