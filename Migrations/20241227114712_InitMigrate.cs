using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReservationSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitMigrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Reservations_reservation_id",
                table: "ResevationDetail");

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

            migrationBuilder.RenameColumn(
                name: "seat_id",
                table: "ResevationDetail",
                newName: "SeatId");

            migrationBuilder.RenameColumn(
                name: "showtime_id",
                table: "ResevationDetail",
                newName: "ShowTimeId");

            migrationBuilder.RenameColumn(
                name: "reservation_id",
                table: "ResevationDetail",
                newName: "ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_ResevationDetail_showtime_id",
                table: "ResevationDetail",
                newName: "IX_ResevationDetail_ShowTimeId");

            migrationBuilder.RenameIndex(
                name: "IX_ResevationDetail_seat_id",
                table: "ResevationDetail",
                newName: "IX_ResevationDetail_SeatId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fd48af1-df71-4466-95ed-e867691acfee", null, "user", "USER" },
                    { "aab5304c-c1af-436a-b2a4-a9caeed72943", null, "admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Reservations_ReservationId",
                table: "ResevationDetail",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Reservations_ReservationId",
                table: "ResevationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_ShowsTime_ShowTimeId",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fd48af1-df71-4466-95ed-e867691acfee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aab5304c-c1af-436a-b2a4-a9caeed72943");

            migrationBuilder.RenameColumn(
                name: "SeatId",
                table: "ResevationDetail",
                newName: "seat_id");

            migrationBuilder.RenameColumn(
                name: "ShowTimeId",
                table: "ResevationDetail",
                newName: "showtime_id");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "ResevationDetail",
                newName: "reservation_id");

            migrationBuilder.RenameIndex(
                name: "IX_ResevationDetail_ShowTimeId",
                table: "ResevationDetail",
                newName: "IX_ResevationDetail_showtime_id");

            migrationBuilder.RenameIndex(
                name: "IX_ResevationDetail_SeatId",
                table: "ResevationDetail",
                newName: "IX_ResevationDetail_seat_id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "76b3060b-6152-42dd-ad1c-da2e2c328f07", null, "user", "USER" },
                    { "c20b527f-30ee-4c3c-ad8a-2475f0cd02ed", null, "admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Reservations_reservation_id",
                table: "ResevationDetail",
                column: "reservation_id",
                principalTable: "Reservations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

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
    }
}
