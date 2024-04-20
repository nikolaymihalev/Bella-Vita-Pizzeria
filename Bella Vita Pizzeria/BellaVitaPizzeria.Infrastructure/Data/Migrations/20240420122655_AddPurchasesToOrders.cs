using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bella_Vita_Pizzeria.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPurchasesToOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PurchasesIds",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11804d9d-ab49-4440-936e-7b76cafe3ec1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a9c7acc-862f-410a-bc6e-64cba63e3252", "AQAAAAIAAYagAAAAEFHB7PxuuWaJ1mvLW4GFeZBGVozb05cBuCClxjXEHkGQl7nG23u8VemRKE/ongXDDw==", "e4050d8d-d089-4b34-953f-880331e457b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e22d31e-db95-4032-9165-2ccaa4865169",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8020e8e1-185e-47af-bceb-4bdd991887bd", "AQAAAAIAAYagAAAAEO17DmxGaqV7J4dA054lsZz/3CwCeMjlmm2OqgigXM+MA2byYd27/aGftRDDBNR60A==", "6e641cd3-7811-4e7c-a18b-92cb4935b0da" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchasesIds",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11804d9d-ab49-4440-936e-7b76cafe3ec1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40f4b634-ea36-4eb1-8056-84d031359f2c", "AQAAAAIAAYagAAAAEGhlX5IaGYwp/sri4nVlt51NN8mRAr57CxSOJdQUcK+fHQm6weeL/XSoRK1ox3nvRg==", "013269ef-389f-45f9-8ed9-1b35837632b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e22d31e-db95-4032-9165-2ccaa4865169",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5a77d81-caa7-4da5-a492-15a1fb531ba0", "AQAAAAIAAYagAAAAECwFY5tiGHTOoa9PP+NB+H3I5XZqgmja6TYAxbgCSPW+o4qKhKSHkWYwrwe3TxOnsQ==", "f489d830-6968-4d93-97bb-8664c809c1a5" });
        }
    }
}
