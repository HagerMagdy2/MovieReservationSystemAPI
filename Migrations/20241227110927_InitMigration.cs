using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReservationSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Seats_seat_id",
                table: "ResevationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_ShowsTime_showtime_id",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17f25c31-06a9-4455-9cf8-7dc0dc5c4eb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dde9c44f-7a7a-44d5-9830-6d29ab3e150a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76b3060b-6152-42dd-ad1c-da2e2c328f07", null, "user", "USER" },
                    { "c20b527f-30ee-4c3c-ad8a-2475f0cd02ed", null, "admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Seats_seat_id",
                table: "ResevationDetail",
                column: "seat_id",
                principalTable: "Seats",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_ShowsTime_showtime_id",
                table: "ResevationDetail",
                column: "showtime_id",
                principalTable: "ShowsTime",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Seats_seat_id",
                table: "ResevationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_ShowsTime_showtime_id",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76b3060b-6152-42dd-ad1c-da2e2c328f07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c20b527f-30ee-4c3c-ad8a-2475f0cd02ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17f25c31-06a9-4455-9cf8-7dc0dc5c4eb5", null, "user", "USER" },
                    { "dde9c44f-7a7a-44d5-9830-6d29ab3e150a", null, "admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Seats_seat_id",
                table: "ResevationDetail",
                column: "seat_id",
                principalTable: "Seats",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_ShowsTime_showtime_id",
                table: "ResevationDetail",
                column: "showtime_id",
                principalTable: "ShowsTime",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
