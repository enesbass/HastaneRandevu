using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HastaneRandevu.DAL.Migrations
{
    /// <inheritdoc />
    public partial class hastalar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Randevular",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(8544),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hastalar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(6876),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Doktorlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(5288),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bolumler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(2887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.InsertData(
                table: "Hastalar",
                columns: new[] { "Id", "Cinsiyeti", "DogumTarihi", "HastaAdi", "HastaSoyadi", "HastaTcNo" },
                values: new object[,]
                {
                    { 1, "Erkek", null, "Ali", "Yilmaz", "12345678901" },
                    { 2, "Erkek", null, "Hasan", "Kaya", "12345678902" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hastalar",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hastalar",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Randevular",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(9700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(8544));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hastalar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(8271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Doktorlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(6770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bolumler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(4354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 16, 13, 42, 14, 367, DateTimeKind.Local).AddTicks(2887));
        }
    }
}
