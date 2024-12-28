using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReservationSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class firstt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13e334dc-58bc-4ccf-89b1-f6a960fc0d1e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ba3bd26-8aac-489b-9674-2f5bf9ed443e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7c4553f9-b315-44c7-9f32-755b8d17e002", null, "admin", "ADMIN" },
                    { "8e988cbc-1ca0-4996-bd68-ce6b83068fc7", null, "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c4553f9-b315-44c7-9f32-755b8d17e002");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e988cbc-1ca0-4996-bd68-ce6b83068fc7");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13e334dc-58bc-4ccf-89b1-f6a960fc0d1e", null, "user", "USER" },
                    { "3ba3bd26-8aac-489b-9674-2f5bf9ed443e", null, "admin", "ADMIN" }
                });
        }
    }
}
