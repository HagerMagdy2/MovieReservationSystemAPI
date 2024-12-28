using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReservationSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitMigrat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fd48af1-df71-4466-95ed-e867691acfee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aab5304c-c1af-436a-b2a4-a9caeed72943");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "ResevationDetail",
                newName: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "67a5a117-3c66-40ea-bcbc-8d76fbe164b3", null, "user", "USER" },
                    { "7d6663c4-2eb1-4a7b-b6f2-1ab93234a682", null, "admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67a5a117-3c66-40ea-bcbc-8d76fbe164b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d6663c4-2eb1-4a7b-b6f2-1ab93234a682");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ResevationDetail",
                newName: "id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fd48af1-df71-4466-95ed-e867691acfee", null, "user", "USER" },
                    { "aab5304c-c1af-436a-b2a4-a9caeed72943", null, "admin", "ADMIN" }
                });
        }
    }
}
