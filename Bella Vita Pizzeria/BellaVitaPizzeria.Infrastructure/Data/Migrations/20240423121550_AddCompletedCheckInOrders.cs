using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bella_Vita_Pizzeria.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCompletedCheckInOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is order completed");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11804d9d-ab49-4440-936e-7b76cafe3ec1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "822e026e-6128-4848-bd26-dfe4180af100", "AQAAAAIAAYagAAAAECG1EMYjGI8BlD+any9k/iWYu6fC9OR4wLFrKnwK3UdtqTDLheIIHkHiWDx8OPn8bA==", "83f44b25-f5e0-45d1-8eb5-22b527544f3a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e22d31e-db95-4032-9165-2ccaa4865169",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb1b0532-4c97-473b-b33f-fccc065a69d2", "AQAAAAIAAYagAAAAEBOW4cJAO8A9Fq+J7L3Yp96LuSm+wbI+is0jOWezDfaPseWBNZss8GiAWD1M7S986A==", "c8995e2e-72b2-40bc-b943-77e37040d22e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Orders");

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
    }
}
