using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Review_Site_Sok_Michael.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jordans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShoeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jordans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    JordansId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Jordans_JordansId",
                        column: x => x.JordansId,
                        principalTable: "Jordans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Jordans",
                columns: new[] { "Id", "Color", "Name", "ShoeType" },
                values: new object[,]
                {
                    { 1, "White/Gray", "Cement 4's", "MidTop" },
                    { 2, "Black/Gray", "Cement 3's", " MidTop" },
                    { 3, "Green/Blue", "Team Jordans", "HighTop" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Description", "JordansId", "Name" },
                values: new object[,]
                {
                    { 1, "Like the color and unique design 8/10", 1, "Cement 4's Review" },
                    { 2, "True to size, durable but laces to short 6/10", 2, "Cement 3's Review" },
                    { 3, "Discolored, not durable, cheap material 3/10", 3, "Team Jordans Review" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_JordansId",
                table: "Reviews",
                column: "JordansId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Jordans");
        }
    }
}
