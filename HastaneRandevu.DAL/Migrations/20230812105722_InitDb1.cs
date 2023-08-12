using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HastaneRandevu.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitDb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolumler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolumAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 478, DateTimeKind.Local).AddTicks(6739))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolumler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hastalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HastaAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HastaSoyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cinsiyeti = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    HastaTcNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 479, DateTimeKind.Local).AddTicks(367))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hastalar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doktorlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DrAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DrSoyadi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BolumId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 478, DateTimeKind.Local).AddTicks(8942))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doktorlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doktorlar_Bolumler_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolumler",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Randevular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RandevuTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RandevuSaati = table.Column<TimeSpan>(type: "time", nullable: false),
                    HastaId = table.Column<int>(type: "int", nullable: true),
                    BolumId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 8, 12, 13, 57, 22, 479, DateTimeKind.Local).AddTicks(1739))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Randevular_Bolumler_BolumId",
                        column: x => x.BolumId,
                        principalTable: "Bolumler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Randevular_Hastalar_HastaId",
                        column: x => x.HastaId,
                        principalTable: "Hastalar",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DoktorHasta",
                columns: table => new
                {
                    DoktorlarId = table.Column<int>(type: "int", nullable: false),
                    HastalarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoktorHasta", x => new { x.DoktorlarId, x.HastalarId });
                    table.ForeignKey(
                        name: "FK_DoktorHasta_Doktorlar_DoktorlarId",
                        column: x => x.DoktorlarId,
                        principalTable: "Doktorlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoktorHasta_Hastalar_HastalarId",
                        column: x => x.HastalarId,
                        principalTable: "Hastalar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bolumler_BolumAdi",
                table: "Bolumler",
                column: "BolumAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoktorHasta_HastalarId",
                table: "DoktorHasta",
                column: "HastalarId");

            migrationBuilder.CreateIndex(
                name: "IX_Doktorlar_BolumId",
                table: "Doktorlar",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_BolumId",
                table: "Randevular",
                column: "BolumId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevular_HastaId",
                table: "Randevular",
                column: "HastaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoktorHasta");

            migrationBuilder.DropTable(
                name: "Randevular");

            migrationBuilder.DropTable(
                name: "Doktorlar");

            migrationBuilder.DropTable(
                name: "Hastalar");

            migrationBuilder.DropTable(
                name: "Bolumler");
        }
    }
}
