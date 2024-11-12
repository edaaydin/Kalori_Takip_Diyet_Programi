using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03_Diyet.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class fifth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "BesinId",
                keyValue: 10,
                columns: new[] { "KaloriMiktarı", "KategoriId", "Resim", "İsmi" },
                values: new object[] { 2.5, 10, "mantı.jpg", "Mantı" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "BesinId",
                keyValue: 10,
                columns: new[] { "KaloriMiktarı", "KategoriId", "Resim", "İsmi" },
                values: new object[] { 2.0, 13, "pilav.jpg", "Pirinç Pilavı" });
        }
    }
}
