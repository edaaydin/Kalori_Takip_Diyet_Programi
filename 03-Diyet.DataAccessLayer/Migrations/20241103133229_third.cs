using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03_Diyet.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Besinler",
                columns: new[] { "BesinId", "KaloriMiktarı", "KategoriId", "Resim", "İsmi" },
                values: new object[] { 16, 3.0, 10, "pizza.jpg", "Pizza" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Besinler",
                keyColumn: "BesinId",
                keyValue: 16);
        }
    }
}
