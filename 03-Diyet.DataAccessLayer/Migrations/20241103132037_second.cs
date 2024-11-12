using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _03_Diyet.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "BesinId",
                keyValue: 22,
                column: "Resim",
                value: "somonfiletoBalik.jpg");

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "BesinId",
                keyValue: 29,
                column: "Resim",
                value: "kiymaliBorek.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "BesinId",
                keyValue: 22,
                column: "Resim",
                value: "somonBaligi.jpg");

            migrationBuilder.UpdateData(
                table: "Besinler",
                keyColumn: "BesinId",
                keyValue: 29,
                column: "Resim",
                value: "kiymali_borek.jpg");
        }
    }
}
