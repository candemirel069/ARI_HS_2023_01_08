namespace WebApp.Data
{
    public class Urun : BaseEntity
    {
        public string Adi { get; set; }
        public string Aciklama { get; set; } 
        public int SeriNo { get; set; }
        public string Renk { get; set; }

        public int KategoriId { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
