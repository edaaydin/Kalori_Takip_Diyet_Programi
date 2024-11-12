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
    public class ÖğünMapping : IEntityTypeConfiguration<Öğün>
    {
        public void Configure(EntityTypeBuilder<Öğün> builder)
        {
            builder.HasData(
                new Öğün
                {
                    ÖğünId = 1,
                    İsmi = "Kahvaltı",
                },
                new Öğün
                {
                    ÖğünId = 2,
                    İsmi = "Öğle Yemeği",
                },
                new Öğün
                {
                    ÖğünId = 3,
                    İsmi = "Akşam Yemeği",
                },
                new Öğün
                {
                    ÖğünId = 4,
                    İsmi = "Aperatifler",
                }

            );
        }
    }
}
