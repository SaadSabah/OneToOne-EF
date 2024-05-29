using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToOne_EF.Migrations
{
    /// <inheritdoc />
    public partial class seedingdata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LasttName" },
                values: new object[] { 4, "Noor", "Mohamad" });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseGrade", "CourseKredit", "CourseName", "StudentId" },
                values: new object[] { 4, 7, 7.5, "Math", 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
