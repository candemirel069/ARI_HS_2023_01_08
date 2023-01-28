using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class UrunContext : DbContext
    {
        public UrunContext(DbContextOptions options) : base(options) { }

        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Kategori>()
                .Property(item => item.KayitTarihi)
                //.HasDefaultValue(DateTime.Now);
                .HasDefaultValueSql("DATETIME('now')");

            modelBuilder.Entity<Urun>()
                .Property(item => item.KayitTarihi)
                .HasDefaultValueSql("DATETIME('now')");

            modelBuilder.Entity<Urun>()
                .Property(x => x.Adi)
                .HasColumnType("char")
                .IsFixedLength(true)
                .HasMaxLength(50);

            modelBuilder.Entity<Urun>()
                .HasIndex(col => new { col.Adi, col.KategoriId})
                .IsUnique();

            modelBuilder.Entity<Kategori>().HasData(
                new Kategori { Id = 1, Adi = "Ram" },
                new Kategori { Id = 2, Adi = "Hdd" },
                new Kategori { Id = 3, Adi = "Cpu" },
                new Kategori { Id = 4, Adi = "Ssd" });
        }
    }
}
