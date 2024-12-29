using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReservationSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Reservations_ReservationId",
                table: "ResevationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4af5f174-fea3-4ef8-8e27-1991de902f4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e9871e7-0072-4d47-aa35-a3df089ca447");

            migrationBuilder.RenameColumn(
                name: "SeatId",
                table: "ResevationDetail",
                newName: "Seatid");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "ResevationDetail",
                newName: "Reservationid");

            migrationBuilder.RenameIndex(
                name: "IX_ResevationDetail_SeatId",
                table: "ResevationDetail",
                newName: "IX_ResevationDetail_Seatid");

            migrationBuilder.AlterColumn<int>(
                name: "Seatid",
                table: "ResevationDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Reservationid",
                table: "ResevationDetail",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "ResevationDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SeatId",
                table: "ResevationDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShowTimeId",
                table: "ResevationDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail",
                columns: new[] { "ReservationId", "SeatId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8716e40b-5837-4f83-8115-18eea8b3734c", null, "admin", "ADMIN" },
                    { "d312e523-8e2c-4617-b341-c2729f91b652", null, "user", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResevationDetail_Reservationid",
                table: "ResevationDetail",
                column: "Reservationid");

            migrationBuilder.CreateIndex(
                name: "IX_ResevationDetail_SeatId",
                table: "ResevationDetail",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_ResevationDetail_ShowTimeId",
                table: "ResevationDetail",
                column: "ShowTimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Reservations_ReservationId",
                table: "ResevationDetail",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Reservations_Reservationid",
                table: "ResevationDetail",
                column: "Reservationid",
                principalTable: "Reservations",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Seats_Seatid",
                table: "ResevationDetail",
                column: "Seatid",
                principalTable: "Seats",
                principalColumn: "id");

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
                name: "FK_ResevationDetail_Reservations_Reservationid",
                table: "ResevationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Seats_Seatid",
                table: "ResevationDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_ShowsTime_ShowTimeId",
                table: "ResevationDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail");

            migrationBuilder.DropIndex(
                name: "IX_ResevationDetail_Reservationid",
                table: "ResevationDetail");

            migrationBuilder.DropIndex(
                name: "IX_ResevationDetail_SeatId",
                table: "ResevationDetail");

            migrationBuilder.DropIndex(
                name: "IX_ResevationDetail_ShowTimeId",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8716e40b-5837-4f83-8115-18eea8b3734c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d312e523-8e2c-4617-b341-c2729f91b652");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "ResevationDetail");

            migrationBuilder.DropColumn(
                name: "SeatId",
                table: "ResevationDetail");

            migrationBuilder.DropColumn(
                name: "ShowTimeId",
                table: "ResevationDetail");

            migrationBuilder.RenameColumn(
                name: "Seatid",
                table: "ResevationDetail",
                newName: "SeatId");

            migrationBuilder.RenameColumn(
                name: "Reservationid",
                table: "ResevationDetail",
                newName: "ReservationId");

            migrationBuilder.RenameIndex(
                name: "IX_ResevationDetail_Seatid",
                table: "ResevationDetail",
                newName: "IX_ResevationDetail_SeatId");

            migrationBuilder.AlterColumn<int>(
                name: "SeatId",
                table: "ResevationDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReservationId",
                table: "ResevationDetail",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail",
                columns: new[] { "ReservationId", "SeatId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4af5f174-fea3-4ef8-8e27-1991de902f4a", null, "admin", "ADMIN" },
                    { "8e9871e7-0072-4d47-aa35-a3df089ca447", null, "user", "USER" }
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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
