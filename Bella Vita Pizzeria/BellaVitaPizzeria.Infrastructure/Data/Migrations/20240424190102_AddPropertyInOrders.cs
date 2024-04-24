using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bella_Vita_Pizzeria.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPropertyInOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Date of creation");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11804d9d-ab49-4440-936e-7b76cafe3ec1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a55e46-82b1-4d17-b94a-b5f6371f1df4", "AQAAAAIAAYagAAAAEK72PPjFCpL0+tp6p5ixlZy9KP4Pr3YmntgS9egxwzVZB69fxdKudsFdxI641NXWWw==", "82cd1f5c-886f-4373-b84c-532c8b886598" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e22d31e-db95-4032-9165-2ccaa4865169",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82daa945-3171-47fe-a904-5b673dcc96a0", "AQAAAAIAAYagAAAAEKCX4iYatXNwAIqJa1Ect2d9CxnU7+n4VNFTv8enRI4Q7xJahDFwf+4WokPZu1A9/Q==", "03191431-75ea-459e-ba58-6d27d831b700" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Orders");

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
    }
}
