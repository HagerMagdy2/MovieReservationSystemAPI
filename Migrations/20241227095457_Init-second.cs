using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieReservationSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initsecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "219b9938-1993-4f1f-8125-2d28c44b2f47");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28adead4-e033-4d07-acdc-462e4534af1e");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "ResevationDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail",
                column: "id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26a0698c-2b1a-4cc8-a9f8-972104040a22", null, "admin", "ADMIN" },
                    { "c8a3f223-f97e-4ce3-8e79-8130e3d4c32f", null, "user", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResevationDetail_reservation_id",
                table: "ResevationDetail",
                column: "reservation_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail");

            migrationBuilder.DropIndex(
                name: "IX_ResevationDetail_reservation_id",
                table: "ResevationDetail");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26a0698c-2b1a-4cc8-a9f8-972104040a22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8a3f223-f97e-4ce3-8e79-8130e3d4c32f");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "ResevationDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResevationDetail",
                table: "ResevationDetail",
                columns: new[] { "reservation_id", "showtime_id" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "219b9938-1993-4f1f-8125-2d28c44b2f47", null, "admin", "ADMIN" },
                    { "28adead4-e033-4d07-acdc-462e4534af1e", null, "user", "USER" }
                });
        }
    }
}
