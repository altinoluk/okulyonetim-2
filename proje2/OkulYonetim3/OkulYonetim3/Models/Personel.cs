using System.ComponentModel.DataAnnotations.Schema;

namespace OkulYonetim3.Models
{
    [Table("Personel")]
    public class Personel
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public string Gorevi { get; set; }
        public string YonetimTip { get; set; }
    }
}
