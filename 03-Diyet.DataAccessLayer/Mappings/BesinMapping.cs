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
    public class BesinMapping : IEntityTypeConfiguration<Besin>
    {
        public void Configure(EntityTypeBuilder<Besin> builder)
        {
            builder.HasOne(b => b.Kategori).WithMany(k => k.Besinler).HasForeignKey(b => b.KategoriId);



            builder.HasData(
                new Besin
                {
                    BesinId = 1,
                    İsmi = "Köfte",
                    KaloriMiktarı = 2,
                    KategoriId = 5,
                    Resim = "köfte.jpg"
                },
                new Besin
                {
                    BesinId = 2,
                    İsmi = "Tavuk Izgara",
                    KaloriMiktarı = 2,
                    KategoriId = 7,
                    Resim = "tavuk.jpg"
                },
                new Besin
                {
                    BesinId = 3,
                    İsmi = "Baklava",
                    KaloriMiktarı = 4,
                    KategoriId = 6,
                    Resim = "baklava.jpg"
                },
                new Besin
                {
                    BesinId = 4,
                    İsmi = "Misket Köfte",
                    KaloriMiktarı = 2,
                    KategoriId = 5,
                    Resim = "misketkofte.jpg"
                },
                new Besin
                {
                    BesinId = 5,
                    İsmi = "Pirinç Pilavı",
                    KaloriMiktarı = 1.3,
                    KategoriId = 13,
                    Resim = "pirincPilavi.jpg"
                },
                new Besin
                {
                    BesinId = 6,
                    İsmi = "Yoğurt",
                    KaloriMiktarı = 1,
                    KategoriId = 12,
                    Resim = "yogurt.jpg"
                },
                new Besin
                {
                    BesinId = 7,
                    İsmi = "Elma",
                    KaloriMiktarı = 1,
                    KategoriId = 3,
                    Resim = "elma.jpg"
                },
                new Besin
                {
                    BesinId = 8,
                    İsmi = "Havuç",
                    KaloriMiktarı = 1,
                    KategoriId = 4,
                    Resim = "havuc.jpg"
                },
                new Besin
                {
                    BesinId = 9,
                    İsmi = "Köri Soslu Makarna",
                    KaloriMiktarı = 2,
                    KategoriId = 1,
                    Resim = "korisoslumakarna.jpg"
                },
                new Besin
                {
                    BesinId = 10,
                    İsmi = "Mantı",
                    KaloriMiktarı = 2.5,
                    KategoriId = 10,
                    Resim = "mantı.jpg"
                },
                new Besin
                {
                    BesinId = 11,
                    İsmi = "Fırında Mantarlı Karides",
                    KaloriMiktarı = 1,
                    KategoriId = 8,
                    Resim = "firinda-mantarli-karides.jpg"
                },
                new Besin
                {
                    BesinId = 12,
                    İsmi = "Hamburger",
                    KaloriMiktarı = 3,
                    KategoriId = 5,
                    Resim = "hamburger.jpg"
                },
                new Besin
                {
                    BesinId = 13,
                    İsmi = "Patates Kızartması",
                    KaloriMiktarı = 3,
                    KategoriId = 4,
                    Resim = "patatesKizartmasi.jpg"
                },
                new Besin
                {
                    BesinId = 14,
                    İsmi = "Sigara Böreği",
                    KaloriMiktarı = 1,
                    KategoriId = 10,
                    Resim = "sigaraBoregi.jpg"
                },
                new Besin
                {
                    BesinId = 15,
                    İsmi = "Beyaz Ekmek",
                    KaloriMiktarı = 2.8,
                    KategoriId = 10,
                    Resim = "beyazEkmekkkkkkk.jpg"
                },
                new Besin
                {
                    BesinId = 16,
                    İsmi = "Pizza",
                    KaloriMiktarı = 3,
                    KategoriId = 10,
                    Resim = "pizza.jpg"
                },
                new Besin
                {
                    BesinId = 17,
                    İsmi = "Beyaz Peynir",
                    KaloriMiktarı = 3.8,
                    KategoriId = 12,
                    Resim = "beyazPeynir.jpg"
                },
                new Besin
                {
                    BesinId = 18,
                    İsmi = "Makarna",
                    KaloriMiktarı = 3.5,
                    KategoriId = 1,
                    Resim = "makarna.jpg"
                },
                new Besin
                {
                    BesinId = 19,
                    İsmi = "Zeytinyağı",
                    KaloriMiktarı = 8.8,
                    KategoriId = 4,
                    Resim = "zeytinyagiiiii.jpg"
                },
                new Besin
                {
                    BesinId = 20,
                    İsmi = "Hindistan Cevizi",
                    KaloriMiktarı = 7.1,
                    KategoriId = 3,
                    Resim = "hindistanCeviz.jpg"
                },
                new Besin
                {
                    BesinId = 21,
                    İsmi = "Kırmızı Biber",
                    KaloriMiktarı = 0.2,
                    KategoriId = 4,
                    Resim = "kirmiziBiber.jpg"
                },
                new Besin
                {
                    BesinId = 22,
                    İsmi = "Somon Balığı",
                    KaloriMiktarı = 2,
                    KategoriId = 8,
                    Resim = "somonfiletoBalik.jpg"
                },
                new Besin
                {
                    BesinId = 23,
                    İsmi = "Fıstık Ezmesi",
                    KaloriMiktarı = 6,
                    KategoriId = 6,
                    Resim = "fistik ezmesi.jpg"
                },
                new Besin
                {
                    BesinId = 24,
                    İsmi = "Çilek",
                    KaloriMiktarı = 0.3,
                    KategoriId = 3,
                    Resim = "cilek.jpg"
                },
                new Besin
                {
                    BesinId = 25,
                    İsmi = "Brokoli",
                    KaloriMiktarı = 0.3,
                    KategoriId = 4,
                    Resim = "brokoli.jpg"
                },
                new Besin
                {
                    BesinId = 26,
                    İsmi = "Kabak",
                    KaloriMiktarı = 0.2,
                    KategoriId = 4,
                    Resim = "kabakpismis.jpg"
                },
                new Besin
                {
                    BesinId = 27,
                    İsmi = "Ananas",
                    KaloriMiktarı = 0.5,
                    KategoriId = 3,
                    Resim = "ananas.jpg"
                },
                new Besin
                {
                    BesinId = 28,
                    İsmi = "Pırasa yemeği",
                    KaloriMiktarı = 1,
                    KategoriId = 4,
                    Resim = "pirasaYemegi.jpg"
                },
                new Besin
                {
                    BesinId = 29,
                    İsmi = "Kıymalı Börek",
                    KaloriMiktarı = 4,
                    KategoriId = 10,
                    Resim = "kiymaliBorek.jpg"
                },
                 new Besin
                 {
                     BesinId = 30,
                     İsmi = "Süzme Yoğurt",
                     KaloriMiktarı = 0.5,
                     KategoriId = 12,
                     Resim = "suzmeYogurt.jpg"
                 },
                 new Besin
                 {
                     BesinId = 31,
                     İsmi = "Kahvaltılık Gevrek",
                     KaloriMiktarı = 3.8,
                     KategoriId = 2,
                     Resim = "kahvaltilikgevrek.jpg"
                 },
                 new Besin
                 {
                     BesinId = 32,
                     İsmi = "Çikolata",
                     KaloriMiktarı = 5.5,
                     KategoriId = 6,
                     Resim = "cikolata.jpg"

                 },
                 new Besin
                 {
                     BesinId = 33,
                     İsmi = "Çoban Salatası",
                     KaloriMiktarı = 1,
                     KategoriId = 11,
                     Resim = "cobanSalata.jpg"
                 },
                 new Besin
                 {
                     BesinId = 34,
                     İsmi = "Yeşil Mercimek Çorbası",
                     KaloriMiktarı = 1,
                     KategoriId = 9,
                     Resim = "yesilMercoCorbasi.jpg"
                 },
                  new Besin
                  {
                      BesinId = 35,
                      İsmi = "Kumpir",
                      KaloriMiktarı = 3,
                      KategoriId = 4,
                      Resim = "kumpir.jpg"
                  },
                   new Besin
                   {
                       BesinId = 36,
                       İsmi = "Zeytinyağlı Enginar",
                       KaloriMiktarı = 1,
                       KategoriId = 4,
                       Resim = "zeytoEnginar,.jpg"
                   },
                   new Besin
                   {
                       BesinId = 37,
                       İsmi = "Portakal Suyu",
                       KaloriMiktarı = 1,
                       KategoriId = 2,
                       Resim = "portokalliMeyveSuyu.jpg"
                   },
                   new Besin
                   {
                       BesinId = 38,
                       İsmi = "Kremalı Sebze Çorbası",
                       KaloriMiktarı = 1.3,
                       KategoriId = 9,
                       Resim = "kremaliSebzeCorbasi.jpg"
                   },
                   new Besin
                   {
                       BesinId = 39,
                       İsmi = "Taze Fasulye",
                       KaloriMiktarı = 1,
                       KategoriId = 4,
                       Resim = "tazeFasulye.jpg"
                   },
                   new Besin
                   {
                       BesinId = 40,
                       İsmi = "Kefir",
                       KaloriMiktarı = 1,
                       KategoriId = 12,
                       Resim = "zeytinEzmeliCıtırEkmek.jpg"
                   },
                   new Besin
                   {
                       BesinId = 41,
                       İsmi = "Zeytin Ezmeli Çıtır Ekmek",
                       KaloriMiktarı = 3,
                       KategoriId = 10,
                       Resim = "zeytinEzmeliCıtırEkmek.jpg"
                   },
                   new Besin
                   {
                       BesinId = 42,
                       İsmi = "Makarna Salatası",
                       KaloriMiktarı = 1,
                       KategoriId = 11,
                       Resim = "makarnaSalatası.jpg"
                   },
                   new Besin
                   {
                       BesinId = 43,
                       İsmi = "Karnabahar",
                       KaloriMiktarı = 0.25,
                       KategoriId = 4,
                       Resim = "karnabaharYemegi.jpg"
                   },
                   new Besin
                   {
                       BesinId = 44,
                       İsmi = "Kuzu Eti",
                       KaloriMiktarı = 2.5,
                       KategoriId = 5,
                       Resim = "KuzuEti.jpg"
                   },
                   new Besin
                   {
                       BesinId = 45,
                       İsmi = "Tavuk Şiş",
                       KaloriMiktarı = 2.2,
                       KategoriId = 7,
                       Resim = "tavukSis.jpg"
                   },
                   new Besin
                   {
                       BesinId = 46,
                       İsmi = "Levrek",
                       KaloriMiktarı = 2,
                       KategoriId = 8,
                       Resim = "levrek.jpg"
                   },
                   new Besin
                   {
                       BesinId = 47,
                       İsmi = "Saray Pilavı",
                       KaloriMiktarı = 1.5,
                       KategoriId = 13,
                       Resim = "sarayPilavi.jpg"
                   },
                   new Besin
                   {
                       BesinId = 48,
                       İsmi = "Biftek",
                       KaloriMiktarı = 2.2,
                       KategoriId = 5,
                       Resim = "Biftek.jpg"
                   },
                   new Besin
                   {
                       BesinId = 49,
                       İsmi = "Penne Arrabbiata",
                       KaloriMiktarı = 3,
                       KategoriId = 1,
                       Resim = "penneArabiata.jpg"
                   },
                   new Besin
                   {
                       BesinId = 50,
                       İsmi = "Profiterol",
                       KaloriMiktarı = 4.5,
                       KategoriId = 6,
                       Resim = "profiterol.jpg"
                   },
                   new Besin
                   {
                       BesinId = 51,
                       İsmi = "Tavuk Kanat",
                       KaloriMiktarı = 2.3,
                       KategoriId = 7,
                       Resim = "tavukKanat.jpg"
                   },
                   new Besin
                   {
                       BesinId = 52,
                       İsmi = "Sardalya",
                       KaloriMiktarı = 1.9,
                       KategoriId = 8,
                       Resim = "sardalya.jpg"
                   },
                   new Besin
                   {
                       BesinId = 53,
                       İsmi = "Mercimek Çorbası",
                       KaloriMiktarı = 1.5,
                       KategoriId = 9,
                       Resim = "mercoCorbasiii.jpg"
                   },
                   new Besin
                   {
                       BesinId = 54,
                       İsmi = "Kinoa Salatası",
                       KaloriMiktarı = 1.7,
                       KategoriId = 11,
                       Resim = "kinoaSalatasi.jpg"
                   },
                   new Besin
                   {
                       BesinId = 55,
                       İsmi = "Kabak Mücver",
                       KaloriMiktarı = 1.5,
                       KategoriId = 4,
                       Resim = "kabakMucver.jpg"
                   },
                   new Besin
                   {
                       BesinId = 56,
                       İsmi = "Tahinli Kabak Tatlısı",
                       KaloriMiktarı = 2,
                       KategoriId = 4,
                       Resim = "tahinliKabakTatlis.jpg"
                   },
                   new Besin
                   {
                       BesinId = 57,
                       İsmi = "Biber Dolması",
                       KaloriMiktarı = 1.8,
                       KategoriId = 4,
                       Resim = "biberDolmasii.jpg"
                   },
                   new Besin
                   {
                       BesinId = 58,
                       İsmi = "Dondurma",
                       KaloriMiktarı = 3,
                       KategoriId = 6,
                       Resim = "dondurmaa.jpg"
                   },
                   new Besin
                   {
                       BesinId = 59,
                       İsmi = "Sushi",
                       KaloriMiktarı = 2.5,
                       KategoriId = 10,
                       Resim = "sushi.jpg"
                   },
                   new Besin
                   {
                       BesinId = 60,
                       İsmi = "Havuçlu Kek",
                       KaloriMiktarı = 4,
                       KategoriId = 6,
                       Resim = "havuclıtatlikek.jpg"
                   },
                   new Besin
                   {
                       BesinId = 61,
                       İsmi = "Bulgur Pilavı",
                       KaloriMiktarı = 1,
                       KategoriId = 13,
                       Resim = "bullgurPilavi.jpg"
                   },
                   new Besin
                   {
                       BesinId = 62,
                       İsmi = "Avokado Salatası",
                       KaloriMiktarı = 2,
                       KategoriId = 11,
                       Resim = "avokadoSalatasi.jpg"
                   },
                   new Besin
                   {
                       BesinId = 63,
                       İsmi = "Sütlü Kahve",
                       KaloriMiktarı = 0.7,
                       KategoriId = 2,
                       Resim = "sütlü kahve.jpg"
                   },
                   new Besin
                   {
                       BesinId = 64,
                       İsmi = "Trileçe",
                       KaloriMiktarı = 2,
                       KategoriId = 6,
                       Resim = "trileçe.jpg"
                   },
                   new Besin
                   {
                       BesinId = 65,
                       İsmi = "Fettuccine Alfredo",
                       KaloriMiktarı = 2,
                       KategoriId = 1,
                       Resim = "fettuciniAlfredo.jpg"
                   },
                   new Besin
                   {
                       BesinId = 66,
                       İsmi = "Sütlaç",
                       KaloriMiktarı = 2,
                       KategoriId = 6,
                       Resim = "sütlac.jpg"
                   },
                   new Besin
                   {
                       BesinId = 67,
                       İsmi = "Kısır",
                       KaloriMiktarı = 1.6,
                       KategoriId = 11,
                       Resim = "kısır.jpg"
                   },
                   new Besin
                   {
                       BesinId = 68,
                       İsmi = "Tavuk Sote",
                       KaloriMiktarı = 2.8,
                       KategoriId = 7,
                       Resim = "tavukSote.jpg"
                   },
                   new Besin
                   {
                       BesinId = 69,
                       İsmi = "Kuru Fasulye",
                       KaloriMiktarı = 2.5,
                       KategoriId = 4,
                       Resim = "kuruFasulye.jpg"
                   },
                   new Besin
                   {
                       BesinId = 70,
                       İsmi = "Patlıcan Musakka",
                       KaloriMiktarı = 3,
                       KategoriId = 4,
                       Resim = "patlıcanMusakka.jpg"
                   },
                   new Besin
                   {
                       BesinId = 71,
                       İsmi = "Etli Nohut",
                       KaloriMiktarı = 2.7,
                       KategoriId = 5,
                       Resim = "etli nohut.jpg"
                   },
                   new Besin
                   {
                       BesinId = 72,
                       İsmi = "Fırında Patates",
                       KaloriMiktarı = 1.5,
                       KategoriId = 4,
                       Resim = "FirindaPatates.jpg"
                   },
                   new Besin
                   {
                       BesinId = 73,
                       İsmi = "Yoğurt Çorbası",
                       KaloriMiktarı = 1.3,
                       KategoriId = 9,
                       Resim = "yogurtCorbası.jpg"
                   },
                   new Besin
                   {
                       BesinId = 74,
                       İsmi = "Hamsi Tava",
                       KaloriMiktarı = 2.6,
                       KategoriId = 8,
                       Resim = "hamsiTava.jpg"
                   },
                   new Besin
                   {
                       BesinId = 75,
                       İsmi = "İçli Köfte",
                       KaloriMiktarı = 3.1,
                       KategoriId = 5,
                       Resim = "icliKöfte.jpg"
                   },
                   new Besin
                   {
                       BesinId = 76,
                       İsmi = "Muhallebi",
                       KaloriMiktarı = 1.5,
                       KategoriId = 6,
                       Resim = "muhallebi.jpg"
                   },
                   new Besin
                   {
                       BesinId = 77,
                       İsmi = "Baklalı Enginar",
                       KaloriMiktarı = 1.8,
                       KategoriId = 4,
                       Resim = "baklaliEnginarYemegi.jpg"
                   },
                   new Besin
                   {
                       BesinId = 78,
                       İsmi = "Paçanga Böreği",
                       KaloriMiktarı = 2.4,
                       KategoriId = 10,
                       Resim = "pacabgaBoregi.jpg"
                   },
                    new Besin
                    {
                        BesinId = 79,
                        İsmi = "Erişte",
                        KaloriMiktarı = 1.9,
                        KategoriId = 1,
                        Resim = "eriste.jpg"
                    },
                     new Besin
                     {
                         BesinId = 80,
                         İsmi = "Taze Börülce Salatası",
                         KaloriMiktarı = 1.2,
                         KategoriId = 11,
                         Resim = "borulcesalatasi.jpg"
                     },
                    new Besin
                    {
                        BesinId = 81,
                        İsmi = "Karnıyarık",
                        KaloriMiktarı = 3,
                        KategoriId = 5,
                        Resim = "karnıyarik.jpg"
                    },
                    new Besin
                    {
                        BesinId = 82,
                        İsmi = "Menemen",
                        KaloriMiktarı = 1.5,
                        KategoriId = 4,
                        Resim = "menemen.jpg"
                    },
                    new Besin
                    {
                        BesinId = 83,
                        İsmi = "Tavuklu Pilav",
                        KaloriMiktarı = 1.9,
                        KategoriId = 13,
                        Resim = "tavuklupilav.jpg"
                    },
                    new Besin
                    {
                        BesinId = 84,
                        İsmi = "Patates Salatası",
                        KaloriMiktarı = 1.2,
                        KategoriId = 11,
                        Resim = "patatesSalatasi.jpg"
                    },
                    new Besin
                    {
                        BesinId = 85,
                        İsmi = "Saray Lokumu",
                        KaloriMiktarı = 3.2,
                        KategoriId = 6,
                        Resim = "sarayLokumu.jpg"

                    },
                    new Besin
                    {
                        BesinId = 86,
                        İsmi = "Cızlak",
                        KaloriMiktarı = 3,
                        KategoriId = 10,
                        Resim = "cızlak.jpg"
                    },
                    new Besin
                    {
                        BesinId = 87,
                        İsmi = "Çılbır",
                        KaloriMiktarı = 1.5,
                        KategoriId = 12,
                        Resim = "cılbır.jpg"
                    },
                    new Besin
                    {
                        BesinId = 88,
                        İsmi = "Tavuklu Makarna",
                        KaloriMiktarı = 1.9,
                        KategoriId = 1,
                        Resim = "tavuklımakarna.jpg"
                    },
                    new Besin
                    {
                        BesinId = 89,
                        İsmi = "Avcı Böreği",
                        KaloriMiktarı = 2.6,
                        KategoriId = 10,
                        Resim = "avciBoregi.jpg"
                    },
                    new Besin
                    {
                        BesinId = 90,
                        İsmi = "Fırında Mantar",
                        KaloriMiktarı = 1.2,
                        KategoriId = 4,
                        Resim = "firindaMantar.jpg"
                    },
                    new Besin
                    {
                        BesinId = 91,
                        İsmi = "Havuç Tarator",
                        KaloriMiktarı = 1,
                        KategoriId = 11,
                        Resim = "havucTarator.jpg"
                    },
                    new Besin
                    {
                        BesinId = 92,
                        İsmi = "Peynirli Krep",
                        KaloriMiktarı = 2,
                        KategoriId = 10,
                        Resim = "peynirliKrep.jpg"
                    },
                    new Besin
                    {
                        BesinId = 93,
                        İsmi = "Barbunya Pilaki",
                        KaloriMiktarı = 1.3,
                        KategoriId = 4,
                        Resim = "barbunyaPilaki.jpg"
                    },
                    new Besin
                    {
                        BesinId = 94,
                        İsmi = "Tahinli Pide",
                        KaloriMiktarı = 3.5,
                        KategoriId = 10,
                        Resim = "tahinliPide.jpg"
                    },
                    new Besin
                    {
                        BesinId = 95,
                        İsmi = "İrmik Helvası",
                        KaloriMiktarı = 3.4,
                        KategoriId = 6,
                        Resim = "İrmikHelvasi.jpg"
                    },
                    new Besin
                    {
                        BesinId = 96,
                        İsmi = "Mercimek Köftesi",
                        KaloriMiktarı = 1.7,
                        KategoriId = 11,
                        Resim = "mercimekKoftesi.jpg"
                    },
                    new Besin
                    {
                        BesinId = 97,
                        İsmi = "Nohutlu Yayla Çorbası",
                        KaloriMiktarı = 1.2,
                        KategoriId = 9,
                        Resim = "yaylacorbasiNohutlu.jpg"
                    },
                    new Besin
                    {
                        BesinId = 98,
                        İsmi = "Karnabahar Graten",
                        KaloriMiktarı = 1.4,
                        KategoriId = 4,
                        Resim = "karnabaharGraten.jpg"
                    },
                     new Besin
                     {
                         BesinId = 99,
                         İsmi = "Tereyağlı Karides",
                         KaloriMiktarı = 2.1,
                         KategoriId = 8,
                         Resim = "tereyağliKarides.jpg"
                     },
                     new Besin
                     {
                         BesinId = 100,
                         İsmi = "Yoğurtlu Semizotu Salatası",
                         KaloriMiktarı = 0.25,
                         KategoriId = 11,
                         Resim = "yogurtlusemizosuSalatasi.jpg"
                     }


            );
        }


    }
}
