using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim3.Models
{
    [Table("Ogrenci")]
    public class Ogrenci
    {
        public int Id { get; set; }
        public string AdSoyad { get; set; }
        public DateTime KayitTarih { get; set; }
        public string OgrenciNo { get; set; }
        public DateTime DTarih { get; set; }
        public string Bolum { get; set; }
    }
}
