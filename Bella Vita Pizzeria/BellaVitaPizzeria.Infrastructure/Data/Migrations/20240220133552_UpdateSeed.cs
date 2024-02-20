using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bella_Vita_Pizzeria.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Ingredients",
                value: "Прясно сварена паста (глутен), доматен сос, сос Болонезе (кайма, лук моркови), кашкавал (млечен продукт), маслина");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Ingredients",
                value: "прясно сварена паста (глутен), доматен сос, сос Болонезе (кайма, лук моркови), кашкавал (млечен продукт), маслина");
        }
    }
}
