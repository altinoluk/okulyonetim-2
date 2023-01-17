using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim3.Models
{
    [Table("Ders")]
    public class Ders
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int  Kredi { get; set; }
        public int OkulYonetimId { get; set; }
        public string DersRenk { get; set; }
    }
}
