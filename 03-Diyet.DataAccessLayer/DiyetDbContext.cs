using _03_Diyet.DataAccessLayer.Mappings;
using _04_Diyet.DATA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer
{
    public class DiyetDbContext : DbContext 
    {
        public DbSet<Besin> Besinler  { get; set; }
        public DbSet<Öğün> Öğünler  { get; set; }
        public DbSet<Profil> Profiller  { get; set; }
        public DbSet<BesinKategori> BesinKategorileri  { get; set; }
        public DbSet<KaloriVeri> KaloriVeriTakip  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=KaloriTakip(Diyet);Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BesinKategoriMapping());
            modelBuilder.ApplyConfiguration(new BesinMapping());
            modelBuilder.ApplyConfiguration(new KaloriVeriMapping());
            modelBuilder.ApplyConfiguration(new ÖğünMapping());
            modelBuilder.ApplyConfiguration(new ProfilMapping());
        }
    }
}
