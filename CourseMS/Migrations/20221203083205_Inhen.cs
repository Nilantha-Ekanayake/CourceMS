using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseMS.Migrations
{
    public partial class Inhen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicCourceLecturer_Person_LecturersId",
                table: "AcademicCourceLecturer");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicCourceStudent_Person_StudentsId",
                table: "AcademicCourceStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_Person_Address_AddressId",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "person");

            migrationBuilder.RenameIndex(
                name: "IX_Person_AddressId",
                table: "person",
                newName: "IX_person_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_person",
                table: "person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicCourceLecturer_person_LecturersId",
                table: "AcademicCourceLecturer",
                column: "LecturersId",
                principalTable: "person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicCourceStudent_person_StudentsId",
                table: "AcademicCourceStudent",
                column: "StudentsId",
                principalTable: "person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_person_Address_AddressId",
                table: "person",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AcademicCourceLecturer_person_LecturersId",
                table: "AcademicCourceLecturer");

            migrationBuilder.DropForeignKey(
                name: "FK_AcademicCourceStudent_person_StudentsId",
                table: "AcademicCourceStudent");

            migrationBuilder.DropForeignKey(
                name: "FK_person_Address_AddressId",
                table: "person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_person",
                table: "person");

            migrationBuilder.RenameTable(
                name: "person",
                newName: "Person");

            migrationBuilder.RenameIndex(
                name: "IX_person_AddressId",
                table: "Person",
                newName: "IX_Person_AddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicCourceLecturer_Person_LecturersId",
                table: "AcademicCourceLecturer",
                column: "LecturersId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AcademicCourceStudent_Person_StudentsId",
                table: "AcademicCourceStudent",
                column: "StudentsId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Person_Address_AddressId",
                table: "Person",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
