using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StudApi.migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExamDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExamName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "studentFee",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PaidOn = table.Column<DateTime>(type: "Date", nullable: false),
                    feepaid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentFee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ExmaName = table.Column<string>(nullable: true),
                    marks = table.Column<int>(nullable: false),
                    ExamDetailsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Marks_ExamDetails_ExamDetailsId",
                        column: x => x.ExamDetailsId,
                        principalTable: "ExamDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "studentMarks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    examId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studentMarks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_studentMarks_ExamDetails_examId",
                        column: x => x.examId,
                        principalTable: "ExamDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    MarksId = table.Column<int>(nullable: true),
                    FeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.id);
                    table.ForeignKey(
                        name: "FK_students_studentFee_FeeId",
                        column: x => x.FeeId,
                        principalTable: "studentFee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_students_studentMarks_MarksId",
                        column: x => x.MarksId,
                        principalTable: "studentMarks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marks_ExamDetailsId",
                table: "Marks",
                column: "ExamDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_studentMarks_examId",
                table: "studentMarks",
                column: "examId");

            migrationBuilder.CreateIndex(
                name: "IX_students_FeeId",
                table: "students",
                column: "FeeId");

            migrationBuilder.CreateIndex(
                name: "IX_students_MarksId",
                table: "students",
                column: "MarksId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marks");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "studentFee");

            migrationBuilder.DropTable(
                name: "studentMarks");

            migrationBuilder.DropTable(
                name: "ExamDetails");
        }
    }
}
