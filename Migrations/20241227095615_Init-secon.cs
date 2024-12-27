using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReservationSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initsecon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_ShowsTime_showtime_id",
                table: "ResevationDetail");

            migrationBuilder.DropIndex(
                name: "IX_ResevationDetail_showtime_id",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26a0698c-2b1a-4cc8-a9f8-972104040a22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8a3f223-f97e-4ce3-8e79-8130e3d4c32f");

            migrationBuilder.DropColumn(
                name: "showtime_id",
                table: "ResevationDetail");

            migrationBuilder.AddColumn<int>(
                name: "ShowTimeid",
                table: "ResevationDetail",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1300fc7a-b245-4ed9-97a8-b5fd9cb94783", null, "user", "USER" },
                    { "974c5930-0481-4f42-bf9f-dd77bb617264", null, "admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResevationDetail_ShowTimeid",
                table: "ResevationDetail",
                column: "ShowTimeid");

            migrationBuilder.AddForeignKey(
                name: "FK_ResevationDetail_ShowsTime_ShowTimeid",
                table: "ResevationDetail",
                column: "ShowTimeid",
                principalTable: "ShowsTime",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResevationDetail_ShowsTime_ShowTimeid",
                table: "ResevationDetail");

            migrationBuilder.DropIndex(
                name: "IX_ResevationDetail_ShowTimeid",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1300fc7a-b245-4ed9-97a8-b5fd9cb94783");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "974c5930-0481-4f42-bf9f-dd77bb617264");

            migrationBuilder.DropColumn(
                name: "ShowTimeid",
                table: "ResevationDetail");

            migrationBuilder.AddColumn<int>(
                name: "showtime_id",
                table: "ResevationDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26a0698c-2b1a-4cc8-a9f8-972104040a22", null, "admin", "ADMIN" },
                    { "c8a3f223-f97e-4ce3-8e79-8130e3d4c32f", null, "user", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResevationDetail_showtime_id",
                table: "ResevationDetail",
                column: "showtime_id");

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
