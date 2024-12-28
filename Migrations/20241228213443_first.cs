using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReservationSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_ShowsTime_ShowTimeId",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "67a5a117-3c66-40ea-bcbc-8d76fbe164b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7d6663c4-2eb1-4a7b-b6f2-1ab93234a682");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_ShowsTime_ShowTimeId",
                table: "ResevationDetail",
                column: "ShowTimeId",
                principalTable: "ShowsTime",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_ShowsTime_ShowTimeId",
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
                    { "67a5a117-3c66-40ea-bcbc-8d76fbe164b3", null, "user", "USER" },
                    { "7d6663c4-2eb1-4a7b-b6f2-1ab93234a682", null, "admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_ShowsTime_ShowTimeId",
                table: "ResevationDetail",
                column: "ShowTimeId",
                principalTable: "ShowsTime",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
