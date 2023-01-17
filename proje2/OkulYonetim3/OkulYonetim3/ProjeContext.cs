using Microsoft.EntityFrameworkCore;

namespace OkulYonetim3
{
    public class ProjeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-L0N7D7L;Initial Catalog=UniSistem;Integrated Security=True;Trusted_Connection=True;");
        }

        public DbSet<Models.Ders> Ders { get; set; }
        public DbSet<Models.Personel> Personel { get; set; }
        public DbSet<Models.Ogrenci> Ogrenci { get; set; }
        public DbSet<Models.OgrenciDers> OgrenciDers { get; set; }

    }
}
