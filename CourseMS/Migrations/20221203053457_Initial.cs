using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseMS.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "academicCource",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfTeachingHours = table.Column<int>(type: "int", nullable: false),
                    NoOfTutorailHours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_academicCource", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "academicCourceOutLine",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_academicCourceOutLine", x => x.Id);
                    table.ForeignKey(
                        name: "FK_academicCourceOutLine_academicCource_CourceId",
                        column: x => x.CourceId,
                        principalTable: "academicCource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<int>(type: "int", nullable: true),
                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EnrolledDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsInternational = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademicCourceLecturer",
                columns: table => new
                {
                    AcademicCourcesId = table.Column<int>(type: "int", nullable: false),
                    LecturersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicCourceLecturer", x => new { x.AcademicCourcesId, x.LecturersId });
                    table.ForeignKey(
                        name: "FK_AcademicCourceLecturer_academicCource_AcademicCourcesId",
                        column: x => x.AcademicCourcesId,
                        principalTable: "academicCource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademicCourceLecturer_Person_LecturersId",
                        column: x => x.LecturersId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademicCourceStudent",
                columns: table => new
                {
                    AcademicCourceId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicCourceStudent", x => new { x.AcademicCourceId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_AcademicCourceStudent_academicCource_AcademicCourceId",
                        column: x => x.AcademicCourceId,
                        principalTable: "academicCource",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademicCourceStudent_Person_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicCourceLecturer_LecturersId",
                table: "AcademicCourceLecturer",
                column: "LecturersId");

            migrationBuilder.CreateIndex(
                name: "IX_academicCourceOutLine_CourceId",
                table: "academicCourceOutLine",
                column: "CourceId");

            migrationBuilder.CreateIndex(
                name: "IX_AcademicCourceStudent_StudentsId",
                table: "AcademicCourceStudent",
                column: "StudentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_AddressId",
                table: "Person",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicCourceLecturer");

            migrationBuilder.DropTable(
                name: "academicCourceOutLine");

            migrationBuilder.DropTable(
                name: "AcademicCourceStudent");

            migrationBuilder.DropTable(
                name: "academicCource");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Address");
        }
    }
}
