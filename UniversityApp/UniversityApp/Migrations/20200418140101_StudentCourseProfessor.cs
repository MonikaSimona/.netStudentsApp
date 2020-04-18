using Microsoft.EntityFrameworkCore.Migrations;

namespace UniversityApp.Migrations
{
    public partial class StudentCourseProfessor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Professor_ProfessorId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_CourseId",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_StudentId",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_CourseId",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_StudentId",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Course_ProfessorId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Course");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Enrollment",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateIndex(
                name: "IX_Course_SecondProfessorId",
                table: "Course",
                column: "SecondProfessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Professor_SecondProfessorId",
                table: "Course",
                column: "SecondProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_Id",
                table: "Enrollment",
                column: "Id",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_Id",
                table: "Enrollment",
                column: "Id",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Professor_SecondProfessorId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_Id",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_Id",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Course_SecondProfessorId",
                table: "Course");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Enrollment",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_CourseId",
                table: "Enrollment",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_StudentId",
                table: "Enrollment",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_ProfessorId",
                table: "Course",
                column: "ProfessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Professor_ProfessorId",
                table: "Course",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_CourseId",
                table: "Enrollment",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_StudentId",
                table: "Enrollment",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
