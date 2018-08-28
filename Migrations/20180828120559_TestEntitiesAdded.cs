using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AccuGazer.API.Migrations
{
    public partial class TestEntitiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GazePoints",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GazePoints", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rectangles",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    X = table.Column<int>(nullable: false),
                    Y = table.Column<int>(nullable: false),
                    Width = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rectangles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RectangleDuration = table.Column<long>(nullable: false),
                    NumberOfRectanglesInTest = table.Column<int>(nullable: false),
                    Shuffle = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StartTime = table.Column<long>(nullable: false),
                    EndTime = table.Column<long>(nullable: false),
                    ScreenWidth = table.Column<int>(nullable: false),
                    ScreenHeight = table.Column<int>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tests_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Measurements",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MeasuredAt = table.Column<long>(nullable: false),
                    IsHit = table.Column<bool>(nullable: false),
                    RectangleId = table.Column<long>(nullable: false),
                    GazePointId = table.Column<long>(nullable: false),
                    TestId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Measurements_GazePoints_GazePointId",
                        column: x => x.GazePointId,
                        principalTable: "GazePoints",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Measurements_Rectangles_RectangleId",
                        column: x => x.RectangleId,
                        principalTable: "Rectangles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Measurements_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_GazePointId",
                table: "Measurements",
                column: "GazePointId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_RectangleId",
                table: "Measurements",
                column: "RectangleId");

            migrationBuilder.CreateIndex(
                name: "IX_Measurements_TestId",
                table: "Measurements",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_UserId",
                table: "Tests",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Measurements");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "GazePoints");

            migrationBuilder.DropTable(
                name: "Rectangles");

            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}
