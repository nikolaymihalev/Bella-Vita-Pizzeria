using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bella_Vita_Pizzeria.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Order identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Client's first name"),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Client's last name"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Client's email"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Client's phone number"),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Client's address - town"),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Client's address - street"),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Client's comment"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "Client's identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Client's order");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11804d9d-ab49-4440-936e-7b76cafe3ec1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4bf17e8-ace7-4b4a-bccf-789f2a1ab05f", "AQAAAAIAAYagAAAAEDrZeV9/odN8tjd8hdFpEMBMuTzwekIPqOCsHurCEe87MrfmGRBsc8443fa9Cw5uYQ==", "e6708579-5655-4477-9f6c-cfbdd114749d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e22d31e-db95-4032-9165-2ccaa4865169",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8599fcbf-7aef-4921-8580-7e0e4175945f", "AQAAAAIAAYagAAAAECQu2rO4pSRXC442Na4qk3Ivxc4fj7UsUYScbXWI1i9Gm99WFmxgcUUV1+Xpgiw81Q==", "a122e9c0-4cad-433c-b734-c9ad14b97758" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

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
        }
    }
}
