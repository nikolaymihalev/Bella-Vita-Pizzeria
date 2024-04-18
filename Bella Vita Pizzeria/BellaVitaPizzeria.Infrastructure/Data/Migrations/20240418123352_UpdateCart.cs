using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bella_Vita_Pizzeria.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchases_Carts_CartId",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_Purchases_CartId",
                table: "Purchases");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "UserId",
                keyValue: "1e22d31e-db95-4032-9165-2ccaa4865169");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "Sum",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "PurchaseId",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Purchase identifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                columns: new[] { "PurchaseId", "UserId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11804d9d-ab49-4440-936e-7b76cafe3ec1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71e88252-9f3f-4c5a-b099-5f4de3fc9e79", "AQAAAAIAAYagAAAAEBcTClk4D7vupHTOqcX8BV5fH6/uLIYzaVqd3aosdYlRiWSmNyjhjhKojfEj50AWCg==", "25a7d3bf-14c2-4b3d-abbd-76c3b76c02d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e22d31e-db95-4032-9165-2ccaa4865169",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "502fc9b8-c414-4601-ac95-929c574d98a6", "AQAAAAIAAYagAAAAEMeMpHOIuJrsal0P6EiWsgpf05F8zIlpfrhXHgGIasDpu+86IeD/u+sArXOzQMtUzw==", "86efc97d-7c61-4a2b-b182-c678974f29a4" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "PurchaseId", "UserId" },
                values: new object[] { 1, "1e22d31e-db95-4032-9165-2ccaa4865169" });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Purchases_PurchaseId",
                table: "Carts",
                column: "PurchaseId",
                principalTable: "Purchases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Purchases_PurchaseId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumns: new[] { "PurchaseId", "UserId" },
                keyColumnTypes: new[] { "int", "nvarchar(450)" },
                keyValues: new object[] { 1, "1e22d31e-db95-4032-9165-2ccaa4865169" });

            migrationBuilder.DropColumn(
                name: "PurchaseId",
                table: "Carts");

            migrationBuilder.AddColumn<string>(
                name: "CartId",
                table: "Purchases",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                comment: "Client's cart identifier");

            migrationBuilder.AddColumn<double>(
                name: "Sum",
                table: "Carts",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                comment: "Order sum");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "UserId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11804d9d-ab49-4440-936e-7b76cafe3ec1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9c2e5af-a2cd-4f50-bfb0-6fee8fc8ea1e", "AQAAAAIAAYagAAAAEATtWGxzdFkfcdhffiZiI9nUslZ43AQLBJbmWNjLGZOxJzSZttujYA0XlSXWV7Jh8Q==", "a9e97609-1e6b-45bd-95e4-f36314b9f547" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e22d31e-db95-4032-9165-2ccaa4865169",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb11eb9c-2c99-45c9-bdc9-f569054b7b7d", "AQAAAAIAAYagAAAAEP94Pi5yiG0ZVJtAM4LxwSzev6436lFdCqKh55nIQ9KdbkUqJTkBUPHKQXot6GrOSA==", "4ab1c61b-4f57-40c7-826f-601647a2a517" });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "UserId", "Sum" },
                values: new object[] { "1e22d31e-db95-4032-9165-2ccaa4865169", 0.0 });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 1,
                column: "CartId",
                value: "1e22d31e-db95-4032-9165-2ccaa4865169");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_CartId",
                table: "Purchases",
                column: "CartId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchases_Carts_CartId",
                table: "Purchases",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
