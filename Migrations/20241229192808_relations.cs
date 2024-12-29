using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReservationSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class relations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5738c6ed-3ed6-4063-aba5-af1e388b88c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f75c9-7610-49ab-b1ee-d7dfa1e98f83");

            migrationBuilder.RenameColumn(
                name: "Type_id",
                table: "Types",
                newName: "id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4af5f174-fea3-4ef8-8e27-1991de902f4a", null, "admin", "ADMIN" },
                    { "8e9871e7-0072-4d47-aa35-a3df089ca447", null, "user", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4af5f174-fea3-4ef8-8e27-1991de902f4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e9871e7-0072-4d47-aa35-a3df089ca447");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Types",
                newName: "Type_id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5738c6ed-3ed6-4063-aba5-af1e388b88c0", null, "admin", "ADMIN" },
                    { "fe3f75c9-7610-49ab-b1ee-d7dfa1e98f83", null, "user", "USER" }
                });
        }
    }
}
