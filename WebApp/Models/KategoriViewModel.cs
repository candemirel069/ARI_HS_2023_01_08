using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class KategoriViewModel
    {
        public int Id { get; set; }
        [Display(Name ="Kategori Adı")]
        public string Adi { get; set; }

        [Display(Name = "Ürün Sayısı")]
        public int UrunSayisi { get; set; }
    }
}
