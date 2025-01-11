using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketApp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "İçecekler" },
                    { 2, "Baharatlar" },
                    { 3, "Tatlılar" },
                    { 4, "Süt Ürünleri" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Çay", 15.00m },
                    { 2, 1, "Kahve", 18.50m },
                    { 3, 1, "Portakal Suyu", 12.00m },
                    { 4, 1, "Şeftali Nektarı", 14.00m },
                    { 5, 1, "Maden Suyu", 8.50m },
                    { 6, 1, "Limonata", 11.00m },
                    { 7, 2, "Pul Biber", 5.00m },
                    { 8, 2, "Kekik", 3.00m },
                    { 9, 2, "Karabiber", 6.50m },
                    { 10, 2, "Kimyon", 4.75m },
                    { 11, 2, "Nane", 2.85m },
                    { 12, 2, "Sumak", 3.50m },
                    { 13, 3, "Baklava", 25.00m },
                    { 14, 3, "Lokum", 15.00m },
                    { 15, 3, "Revani", 12.00m },
                    { 16, 3, "Kazandibi", 10.00m },
                    { 17, 3, "Şekerpare", 11.50m },
                    { 18, 3, "Künefe", 20.00m },
                    { 19, 4, "Beyaz Peynir", 35.00m },
                    { 20, 4, "Kaşar Peynir", 45.00m },
                    { 21, 4, "Tereyağı", 40.00m },
                    { 22, 4, "Yoğurt", 12.00m },
                    { 23, 4, "Ayran", 5.00m },
                    { 24, 4, "Labne", 16.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
