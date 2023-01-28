using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data
{
    public class Kategori : BaseEntity
    {
        [Column(TypeName ="Varchar")]
        [StringLength(50)]
        public string Adi { get; set; }

        public virtual List<Urun> Urunler { get; set; }
    }
}
