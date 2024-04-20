using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bella_Vita_Pizzeria.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Client's address - town",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Client's address - town");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Orders",
                type: "nvarchar(80)",
                maxLength: 80,
                nullable: false,
                comment: "Client's address - street",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Client's address - street");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                comment: "Client's phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Client's phone number");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Client's last name",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Client's last name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Client's first name",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Client's first name");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                comment: "Client's email",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Client's email");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11804d9d-ab49-4440-936e-7b76cafe3ec1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aec84f57-dad0-4c14-80d1-f326c27cf5d5", "AQAAAAIAAYagAAAAECr1cljkGcG7cwlMLpIvHIKYRZA4OHObOUUTNlycwOpiZ6H06Rsbx14zlf29sCE3Sw==", "3cc242df-2bb9-4f74-a52b-793bb559f23a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e22d31e-db95-4032-9165-2ccaa4865169",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac3a39e0-4b58-4fd7-b042-a8fe42a431ee", "AQAAAAIAAYagAAAAEE/1oaMaxYHq422/I7tYyzGJgjB3YdHo4PoKlkh9AFD9qqE7+CvK7bYRWTOvrAwzFw==", "6207879e-8442-4c20-881d-d61e997db4eb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Town",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Client's address - town",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Client's address - town");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Client's address - street",
                oldClrType: typeof(string),
                oldType: "nvarchar(80)",
                oldMaxLength: 80,
                oldComment: "Client's address - street");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Client's phone number",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20,
                oldComment: "Client's phone number");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Client's last name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Client's last name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Client's first name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Client's first name");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                comment: "Client's email",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldComment: "Client's email");

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
        }
    }
}
