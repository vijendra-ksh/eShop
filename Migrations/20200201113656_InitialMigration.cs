using Microsoft.EntityFrameworkCore.Migrations;

namespace eShop.Migrations
{
public partial class InitialMigration : Migration
{
protected override void Up(MigrationBuilder migrationBuilder)
{
migrationBuilder.CreateTable(
name: "Categories",
columns: table => new
{
    CategoryId = table.Column<int>(nullable: false)
        .Annotation("SqlServer:Identity", "1, 1"),
    CategoryName = table.Column<string>(nullable: true),
    CategoryDescription = table.Column<string>(nullable: true)
},
constraints: table =>
{
    table.PrimaryKey("PK_Categories", x => x.CategoryId);
});

migrationBuilder.CreateTable(
name: "Products",
columns: table => new
{
    ProductId = table.Column<int>(nullable: false)
        .Annotation("SqlServer:Identity", "1, 1"),
    Name = table.Column<string>(nullable: true),
    Description = table.Column<string>(nullable: true),
    Price = table.Column<decimal>(nullable: false),
    ImageUrl = table.Column<string>(nullable: true),
    ImageThumbnailUrl = table.Column<string>(nullable: true),
    IsOnSale = table.Column<bool>(nullable: false),
    IsInStock = table.Column<bool>(nullable: false),
    CategoryId = table.Column<int>(nullable: false)
},
constraints: table =>
{
    table.PrimaryKey("PK_Products", x => x.ProductId);
    table.ForeignKey(
        name: "FK_Products_Categories_CategoryId",
        column: x => x.CategoryId,
        principalTable: "Categories",
        principalColumn: "CategoryId",
        onDelete: ReferentialAction.Cascade);
});

migrationBuilder.CreateIndex(
name: "IX_Products_CategoryId",
table: "Products",
column: "CategoryId");
}

protected override void Down(MigrationBuilder migrationBuilder)
{
migrationBuilder.DropTable(
name: "Products");

migrationBuilder.DropTable(
name: "Categories");
}
}
}
