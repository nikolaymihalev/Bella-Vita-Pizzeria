using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bella_Vita_Pizzeria.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixConstraint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                comment: "Client's last name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Client's last name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                comment: "Client's first name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Client's first name");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Client's last name",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldComment: "Client's last name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Client's first name",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldComment: "Client's first name");

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
    }
}
