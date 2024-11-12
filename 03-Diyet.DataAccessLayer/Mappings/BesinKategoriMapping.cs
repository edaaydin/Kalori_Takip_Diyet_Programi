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
    public class BesinKategoriMapping : IEntityTypeConfiguration<BesinKategori>
    {
        public void Configure(EntityTypeBuilder<BesinKategori> builder)
        {
            builder.HasData(
                 new BesinKategori
                 {
                     BesinKategoriId = 1,
                     İsmi = "Makarnalar"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 2,
                     İsmi = "İçecekler"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 3,
                     İsmi = "Meyveler"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 4,
                     İsmi = "Sebzeler"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 5,
                     İsmi = "Et Ürünleri"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 6,
                     İsmi = "Tatlılar"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 7,
                     İsmi = "Tavuk Ürünleri"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 8,
                     İsmi = "Balık Ürünleri"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 9,
                     İsmi = "Çorbalar"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 10,
                     İsmi = "Unlu Mamuller"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 11,
                     İsmi = "Salatalar"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 12,
                     İsmi = "Süt Ve Süt Ürünleri"
                 },
                 new BesinKategori
                 {
                     BesinKategoriId = 13,
                     İsmi = "Pilavlar"
                 }
             );
        }
    }
}
