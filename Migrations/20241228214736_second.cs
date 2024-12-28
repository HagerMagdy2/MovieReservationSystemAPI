using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReservationSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail");

            migrationBuilder.DropIndex(
                name: "IX_ResevationDetail_ShowTimeId",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "523719d2-241a-456d-af4e-404e78354240");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9fe6d07e-4792-4966-853d-24564a89c89b");

            migrationBuilder.DropColumn(
                name: "ShowTimeId",
                table: "ResevationDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail",
                columns: new[] { "ReservationId", "SeatId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5738c6ed-3ed6-4063-aba5-af1e388b88c0", null, "admin", "ADMIN" },
                    { "fe3f75c9-7610-49ab-b1ee-d7dfa1e98f83", null, "user", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail",
                column: "SeatId",
                principalTable: "Seats",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_Seats_SeatId",
                table: "ResevationDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5738c6ed-3ed6-4063-aba5-af1e388b88c0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fe3f75c9-7610-49ab-b1ee-d7dfa1e98f83");

            migrationBuilder.AddColumn<int>(
                name: "ShowTimeId",
                table: "ResevationDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail",
                columns: new[] { "ReservationId", "ShowTimeId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "523719d2-241a-456d-af4e-404e78354240", null, "user", "USER" },
                    { "9fe6d07e-4792-4966-853d-24564a89c89b", null, "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResevationDetail_ShowTimeId",
                table: "ResevationDetail",
                column: "ShowTimeId");

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
