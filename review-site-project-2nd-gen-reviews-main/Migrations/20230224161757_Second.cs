using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Review_Site_Sok_Michael.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Jordans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Jordans",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://images.51microshop.com/11489/product/20220211/OG_Jordan_4_Retro_White_Cement_2016_840606_192_1644575350130_0.jpg");

            migrationBuilder.UpdateData(
                table: "Jordans",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageURL",
                value: "https://sneakernews.com/wp-content/uploads/2018/01/jordan-3-black-cement-official-images-2.jpg");

            migrationBuilder.UpdateData(
                table: "Jordans",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Color", "ImageURL" },
                values: new object[] { "Green/Black", "https://images.jordansdaily.com/wp-content/uploads/2014/02/jordan-flight-45-high-black-venom-green-02.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Jordans");

            migrationBuilder.UpdateData(
                table: "Jordans",
                keyColumn: "Id",
                keyValue: 3,
                column: "Color",
                value: "Green/Blue");
        }
    }
}
