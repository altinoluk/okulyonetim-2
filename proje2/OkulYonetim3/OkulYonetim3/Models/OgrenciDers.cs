using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetim3.Models
{
    [Table("OgrenciDers")]
    public class OgrenciDers
    {
        public int Id { get; set; }
        public int DersId { get; set; }
        public int OgrenciId { get; set; }
    }
}
