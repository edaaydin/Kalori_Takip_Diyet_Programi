using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _03_Diyet.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BesinKategorileri",
                columns: table => new
                {
                    BesinKategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsmi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinKategorileri", x => x.BesinKategoriId);
                });

            migrationBuilder.CreateTable(
                name: "Öğünler",
                columns: table => new
                {
                    ÖğünId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsmi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Öğünler", x => x.ÖğünId);
                });

            migrationBuilder.CreateTable(
                name: "Profiller",
                columns: table => new
                {
                    ProfilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoğumTarihi = table.Column<DateTime>(type: "date", nullable: false),
                    Boy = table.Column<int>(type: "int", nullable: false),
                    Kilo = table.Column<int>(type: "int", nullable: false),
                    Cinsiyet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullanıcıEposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Şifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilOluşturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiller", x => x.ProfilId);
                });

            migrationBuilder.CreateTable(
                name: "Besinler",
                columns: table => new
                {
                    BesinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    İsmi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KaloriMiktarı = table.Column<double>(type: "float", nullable: false),
                    Resim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besinler", x => x.BesinId);
                    table.ForeignKey(
                        name: "FK_Besinler_BesinKategorileri_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "BesinKategorileri",
                        principalColumn: "BesinKategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KaloriVeriTakip",
                columns: table => new
                {
                    KaloriVeriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    OluşturulmaTarihi = table.Column<DateTime>(type: "date", nullable: false),
                    BesinId = table.Column<int>(type: "int", nullable: false),
                    ÖğünId = table.Column<int>(type: "int", nullable: false),
                    ProfilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KaloriVeriTakip", x => x.KaloriVeriId);
                    table.ForeignKey(
                        name: "FK_KaloriVeriTakip_Besinler_BesinId",
                        column: x => x.BesinId,
                        principalTable: "Besinler",
                        principalColumn: "BesinId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KaloriVeriTakip_Profiller_ProfilId",
                        column: x => x.ProfilId,
                        principalTable: "Profiller",
                        principalColumn: "ProfilId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KaloriVeriTakip_Öğünler_ÖğünId",
                        column: x => x.ÖğünId,
                        principalTable: "Öğünler",
                        principalColumn: "ÖğünId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BesinKategorileri",
                columns: new[] { "BesinKategoriId", "İsmi" },
                values: new object[,]
                {
                    { 1, "Makarnalar" },
                    { 2, "İçecekler" },
                    { 3, "Meyveler" },
                    { 4, "Sebzeler" },
                    { 5, "Et Ürünleri" },
                    { 6, "Tatlılar" },
                    { 7, "Tavuk Ürünleri" },
                    { 8, "Balık Ürünleri" },
                    { 9, "Çorbalar" },
                    { 10, "Unlu Mamuller" },
                    { 11, "Salatalar" },
                    { 12, "Süt Ve Süt Ürünleri" },
                    { 13, "Pilavlar" }
                });

            migrationBuilder.InsertData(
                table: "Öğünler",
                columns: new[] { "ÖğünId", "İsmi" },
                values: new object[,]
                {
                    { 1, "Kahvaltı" },
                    { 2, "Öğle Yemeği" },
                    { 3, "Akşam Yemeği" },
                    { 4, "Aperatifler" }
                });

            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "BesinId", "KaloriMiktarı", "KategoriId", "Resim", "İsmi" },
                values: new object[,]
                {
                    { 1, 2.0, 5, "köfte.jpg", "Köfte" },
                    { 2, 2.0, 7, "tavuk.jpg", "Tavuk Izgara" },
                    { 3, 4.0, 6, "baklava.jpg", "Baklava" },
                    { 4, 2.0, 5, "misketkofte.jpg", "Misket Köfte" },
                    { 5, 1.3, 13, "pirincPilavi.jpg", "Pirinç Pilavı" },
                    { 6, 1.0, 12, "yogurt.jpg", "Yoğurt" },
                    { 7, 1.0, 3, "elma.jpg", "Elma" },
                    { 8, 1.0, 4, "havuc.jpg", "Havuç" },
                    { 9, 2.0, 1, "korisoslumakarna.jpg", "Köri Soslu Makarna" },
                    { 10, 2.0, 13, "pilav.jpg", "Pirinç Pilavı" },
                    { 11, 1.0, 8, "firinda-mantarli-karides.jpg", "Fırında Mantarlı Karides" },
                    { 12, 3.0, 5, "hamburger.jpg", "Hamburger" },
                    { 13, 3.0, 4, "patatesKizartmasi.jpg", "Patates Kızartması" },
                    { 14, 1.0, 10, "sigaraBoregi.jpg", "Sigara Böreği" },
                    { 15, 2.7999999999999998, 10, "beyazEkmekkkkkkk.jpg", "Beyaz Ekmek" },
                    { 17, 3.7999999999999998, 12, "beyazPeynir.jpg", "Beyaz Peynir" },
                    { 18, 3.5, 1, "makarna.jpg", "Makarna" },
                    { 19, 8.8000000000000007, 4, "zeytinyagiiiii.jpg", "Zeytinyağı" },
                    { 20, 7.0999999999999996, 3, "hindistanCeviz.jpg", "Hindistan Cevizi" },
                    { 21, 0.20000000000000001, 4, "kirmiziBiber.jpg", "Kırmızı Biber" },
                    { 22, 2.0, 8, "somonBaligi.jpg", "Somon Balığı" },
                    { 23, 6.0, 6, "fistik ezmesi.jpg", "Fıstık Ezmesi" },
                    { 24, 0.29999999999999999, 3, "cilek.jpg", "Çilek" },
                    { 25, 0.29999999999999999, 4, "brokoli.jpg", "Brokoli" },
                    { 26, 0.20000000000000001, 4, "kabakpismis.jpg", "Kabak" },
                    { 27, 0.5, 3, "ananas.jpg", "Ananas" },
                    { 28, 1.0, 4, "pirasaYemegi.jpg", "Pırasa yemeği" },
                    { 29, 4.0, 10, "kiymali_borek.jpg", "Kıymalı Börek" },
                    { 30, 0.5, 12, "suzmeYogurt.jpg", "Süzme Yoğurt" },
                    { 31, 3.7999999999999998, 2, "kahvaltilikgevrek.jpg", "Kahvaltılık Gevrek" },
                    { 32, 5.5, 6, "cikolata.jpg", "Çikolata" },
                    { 33, 1.0, 11, "cobanSalata.jpg", "Çoban Salatası" },
                    { 34, 1.0, 9, "yesilMercoCorbasi.jpg", "Yeşil Mercimek Çorbası" },
                    { 35, 3.0, 4, "kumpir.jpg", "Kumpir" },
                    { 36, 1.0, 4, "zeytoEnginar,.jpg", "Zeytinyağlı Enginar" },
                    { 37, 1.0, 2, "portokalliMeyveSuyu.jpg", "Portakal Suyu" },
                    { 38, 1.3, 9, "kremaliSebzeCorbasi.jpg", "Kremalı Sebze Çorbası" },
                    { 39, 1.0, 4, "tazeFasulye.jpg", "Taze Fasulye" },
                    { 40, 1.0, 12, "zeytinEzmeliCıtırEkmek.jpg", "Kefir" },
                    { 41, 3.0, 10, "zeytinEzmeliCıtırEkmek.jpg", "Zeytin Ezmeli Çıtır Ekmek" },
                    { 42, 1.0, 11, "makarnaSalatası.jpg", "Makarna Salatası" },
                    { 43, 0.25, 4, "karnabaharYemegi.jpg", "Karnabahar" },
                    { 44, 2.5, 5, "KuzuEti.jpg", "Kuzu Eti" },
                    { 45, 2.2000000000000002, 7, "tavukSis.jpg", "Tavuk Şiş" },
                    { 46, 2.0, 8, "levrek.jpg", "Levrek" },
                    { 47, 1.5, 13, "sarayPilavi.jpg", "Saray Pilavı" },
                    { 48, 2.2000000000000002, 5, "Biftek.jpg", "Biftek" },
                    { 49, 3.0, 1, "penneArabiata.jpg", "Penne Arrabbiata" },
                    { 50, 4.5, 6, "profiterol.jpg", "Profiterol" },
                    { 51, 2.2999999999999998, 7, "tavukKanat.jpg", "Tavuk Kanat" },
                    { 52, 1.8999999999999999, 8, "sardalya.jpg", "Sardalya" },
                    { 53, 1.5, 9, "mercoCorbasiii.jpg", "Mercimek Çorbası" },
                    { 54, 1.7, 11, "kinoaSalatasi.jpg", "Kinoa Salatası" },
                    { 55, 1.5, 4, "kabakMucver.jpg", "Kabak Mücver" },
                    { 56, 2.0, 4, "tahinliKabakTatlis.jpg", "Tahinli Kabak Tatlısı" },
                    { 57, 1.8, 4, "biberDolmasii.jpg", "Biber Dolması" },
                    { 58, 3.0, 6, "dondurmaa.jpg", "Dondurma" },
                    { 59, 2.5, 10, "sushi.jpg", "Sushi" },
                    { 60, 4.0, 6, "havuclıtatlikek.jpg", "Havuçlu Kek" },
                    { 61, 1.0, 13, "bullgurPilavi.jpg", "Bulgur Pilavı" },
                    { 62, 2.0, 11, "avokadoSalatasi.jpg", "Avokado Salatası" },
                    { 63, 0.69999999999999996, 2, "sütlü kahve.jpg", "Sütlü Kahve" },
                    { 64, 2.0, 6, "trileçe.jpg", "Trileçe" },
                    { 65, 2.0, 1, "fettuciniAlfredo.jpg", "Fettuccine Alfredo" },
                    { 66, 2.0, 6, "sütlac.jpg", "Sütlaç" },
                    { 67, 1.6000000000000001, 11, "kısır.jpg", "Kısır" },
                    { 68, 2.7999999999999998, 7, "tavukSote.jpg", "Tavuk Sote" },
                    { 69, 2.5, 4, "kuruFasulye.jpg", "Kuru Fasulye" },
                    { 70, 3.0, 4, "patlıcanMusakka.jpg", "Patlıcan Musakka" },
                    { 71, 2.7000000000000002, 5, "etli nohut.jpg", "Etli Nohut" },
                    { 72, 1.5, 4, "FirindaPatates.jpg", "Fırında Patates" },
                    { 73, 1.3, 9, "yogurtCorbası.jpg", "Yoğurt Çorbası" },
                    { 74, 2.6000000000000001, 8, "hamsiTava.jpg", "Hamsi Tava" },
                    { 75, 3.1000000000000001, 5, "icliKöfte.jpg", "İçli Köfte" },
                    { 76, 1.5, 6, "muhallebi.jpg", "Muhallebi" },
                    { 77, 1.8, 4, "baklaliEnginarYemegi.jpg", "Baklalı Enginar" },
                    { 78, 2.3999999999999999, 10, "pacabgaBoregi.jpg", "Paçanga Böreği" },
                    { 79, 1.8999999999999999, 1, "eriste.jpg", "Erişte" },
                    { 80, 1.2, 11, "borulcesalatasi.jpg", "Taze Börülce Salatası" },
                    { 81, 3.0, 5, "karnıyarik.jpg", "Karnıyarık" },
                    { 82, 1.5, 4, "menemen.jpg", "Menemen" },
                    { 83, 1.8999999999999999, 13, "tavuklupilav.jpg", "Tavuklu Pilav" },
                    { 84, 1.2, 11, "patatesSalatasi.jpg", "Patates Salatası" },
                    { 85, 3.2000000000000002, 6, "sarayLokumu.jpg", "Saray Lokumu" },
                    { 86, 3.0, 10, "cızlak.jpg", "Cızlak" },
                    { 87, 1.5, 12, "cılbır.jpg", "Çılbır" },
                    { 88, 1.8999999999999999, 1, "tavuklımakarna.jpg", "Tavuklu Makarna" },
                    { 89, 2.6000000000000001, 10, "avciBoregi.jpg", "Avcı Böreği" },
                    { 90, 1.2, 4, "firindaMantar.jpg", "Fırında Mantar" },
                    { 91, 1.0, 11, "havucTarator.jpg", "Havuç Tarator" },
                    { 92, 2.0, 10, "peynirliKrep.jpg", "Peynirli Krep" },
                    { 93, 1.3, 4, "barbunyaPilaki.jpg", "Barbunya Pilaki" },
                    { 94, 3.5, 10, "tahinliPide.jpg", "Tahinli Pide" },
                    { 95, 3.3999999999999999, 6, "İrmikHelvasi.jpg", "İrmik Helvası" },
                    { 96, 1.7, 11, "mercimekKoftesi.jpg", "Mercimek Köftesi" },
                    { 97, 1.2, 9, "yaylacorbasiNohutlu.jpg", "Nohutlu Yayla Çorbası" },
                    { 98, 1.3999999999999999, 4, "karnabaharGraten.jpg", "Karnabahar Graten" },
                    { 99, 2.1000000000000001, 8, "tereyağliKarides.jpg", "Tereyağlı Karides" },
                    { 100, 0.25, 11, "yogurtlusemizosuSalatasi.jpg", "Yoğurtlu Semizotu Salatası" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Besinler_KategoriId",
                table: "Besinler",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_KaloriVeriTakip_BesinId",
                table: "KaloriVeriTakip",
                column: "BesinId");

            migrationBuilder.CreateIndex(
                name: "IX_KaloriVeriTakip_ÖğünId",
                table: "KaloriVeriTakip",
                column: "ÖğünId");

            migrationBuilder.CreateIndex(
                name: "IX_KaloriVeriTakip_ProfilId",
                table: "KaloriVeriTakip",
                column: "ProfilId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KaloriVeriTakip");

            migrationBuilder.DropTable(
                name: "Besinler");

            migrationBuilder.DropTable(
                name: "Profiller");

            migrationBuilder.DropTable(
                name: "Öğünler");

            migrationBuilder.DropTable(
                name: "BesinKategorileri");
        }
    }
}
