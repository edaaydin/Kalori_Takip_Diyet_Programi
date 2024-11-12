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
    public class ProfilMapping : IEntityTypeConfiguration<Profil>
    {
        public void Configure(EntityTypeBuilder<Profil> builder)
        {
            builder.Property(p => p.DoğumTarihi).HasColumnType("date");
        }
    }
}
