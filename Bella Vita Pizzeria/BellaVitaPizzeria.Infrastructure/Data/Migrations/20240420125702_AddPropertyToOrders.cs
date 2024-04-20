using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bella_Vita_Pizzeria.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertyToOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalSum",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                comment: "Purchases total sum");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11804d9d-ab49-4440-936e-7b76cafe3ec1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7d3bed3-c141-4678-a6e8-4e9e01c78f86", "AQAAAAIAAYagAAAAECf8FV+X03nyl+xZggPthlvpaq0cKMg7REaRv09olN9092mOybRUatwz4cAKpGcidA==", "4e9fee91-f2ee-436a-b2a4-bcfafdc52483" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e22d31e-db95-4032-9165-2ccaa4865169",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1034f5ab-72cb-417e-a0fc-b1f36cedb231", "AQAAAAIAAYagAAAAENj6u4fLyHdp+QjVc5ity1uKSmuVugjqPoW2iwPtINCVmrUSxYifFfaeK1kxws0KwA==", "6e5d2b5a-a304-4d6b-ae9a-0d43aa8008c2" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalSum",
                table: "Orders");

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
    }
}
