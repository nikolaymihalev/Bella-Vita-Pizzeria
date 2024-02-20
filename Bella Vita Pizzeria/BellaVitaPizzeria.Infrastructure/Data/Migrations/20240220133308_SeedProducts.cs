using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bella_Vita_Pizzeria.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "Products",
                type: "int",
                nullable: false,
                comment: "Тегло на продукта",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Тегло на продукта");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Снимка на продукта");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceForPizzaBig",
                table: "Products",
                type: "decimal(18,8)",
                precision: 18,
                scale: 8,
                nullable: false,
                defaultValue: 0m,
                comment: "Цена за продукт(пица) голяма");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceForPizzaFamily",
                table: "Products",
                type: "decimal(18,8)",
                precision: 18,
                scale: 8,
                nullable: false,
                defaultValue: 0m,
                comment: "Цена за продукт(пица) семейна");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ImageUrl", "Ingredients", "Price", "PriceForPizzaBig", "PriceForPizzaFamily", "Title", "Weight" },
                values: new object[,]
                {
                    { 1, 1, "https://cdn4.focus.bg/fakti/photos/big/4cb/recepta-za-vechera-pica-karbonara-1.jpg", "Пица с домашно приготвено прясно тесто (глутен), сметана (млечен продукт), прошуто кото, кашкавал (млечен продукт), яйце (яйце)", 15m, 16m, 43m, "Пица Карбонара", 0 },
                    { 2, 2, "https://leonardobansko.bg/wp-content/uploads/2020/07/2020-07-27_13h48_32-601x385.png", "прясно сварена паста (глутен), доматен сос, сос Болонезе (кайма, лук моркови), кашкавал (млечен продукт), маслина", 15.5m, 0m, 0m, "Спагети Болонезе", 400 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PriceForPizzaBig",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PriceForPizzaFamily",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Weight",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Тегло на продукта",
                oldClrType: typeof(int),
                oldType: "int",
                oldComment: "Тегло на продукта");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Products",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0],
                comment: "Снимка на продукта");
        }
    }
}
