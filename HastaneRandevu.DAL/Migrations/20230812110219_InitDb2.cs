using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneRandevu.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Randevular",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(9700),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 479, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.AddColumn<int>(
                name: "DoktorId",
                table: "Randevular",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hastalar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(8271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 479, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Doktorlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(6770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 478, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bolumler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(4354),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 478, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_DoktorId",
                table: "Randevular",
                column: "DoktorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevular_Doktorlar_DoktorId",
                table: "Randevular",
                column: "DoktorId",
                principalTable: "Doktorlar",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevular_Doktorlar_DoktorId",
                table: "Randevular");

            migrationBuilder.DropIndex(
                name: "IX_Randevular_DoktorId",
                table: "Randevular");

            migrationBuilder.DropColumn(
                name: "DoktorId",
                table: "Randevular");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Randevular",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 479, DateTimeKind.Local).AddTicks(1739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(9700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Hastalar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 479, DateTimeKind.Local).AddTicks(367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Doktorlar",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 478, DateTimeKind.Local).AddTicks(8942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Bolumler",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 478, DateTimeKind.Local).AddTicks(6739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 12, 14, 2, 18, 967, DateTimeKind.Local).AddTicks(4354));
        }
    }
}
