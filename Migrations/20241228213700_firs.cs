using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReservationSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class firs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fccd085-480a-4b58-8da8-9a76a96a3a17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c983595-6bf4-41ab-b315-f057f5614be9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "13e334dc-58bc-4ccf-89b1-f6a960fc0d1e", null, "user", "USER" },
                    { "3ba3bd26-8aac-489b-9674-2f5bf9ed443e", null, "admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail");

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
                    { "5fccd085-480a-4b58-8da8-9a76a96a3a17", null, "admin", "ADMIN" },
                    { "9c983595-6bf4-41ab-b315-f057f5614be9", null, "user", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
