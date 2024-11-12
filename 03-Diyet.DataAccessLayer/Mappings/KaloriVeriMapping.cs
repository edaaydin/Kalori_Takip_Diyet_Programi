using _04_Diyet.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Diyet.DataAccessLayer.Mappings
{
    public class KaloriVeriMapping : IEntityTypeConfiguration<KaloriVeri>
    {
        public void Configure(EntityTypeBuilder<KaloriVeri> builder)
        {
            builder.HasOne(k => k.Öğün).WithMany(ö => ö.KaloriVerileri).HasForeignKey(k => k.ÖğünId);
            
            builder.HasOne(k => k.Profil).WithMany(ö => ö.KaloriVerileri).HasForeignKey(k => k.ProfilId);
            
            builder.HasOne(k => k.Besin).WithMany(ö => ö.KaloriVerileri).HasForeignKey(k => k.BesinId);

            builder.Property(k => k.OluşturulmaTarihi).HasColumnType("date");
        }
    }
}
