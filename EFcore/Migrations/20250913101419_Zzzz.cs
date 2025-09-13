using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFcore.Migrations
{
    /// <inheritdoc />
    public partial class Zzzz : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NameD",
                table: "Departments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Departments",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "NameD");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Departments",
                newName: "DepartmentId");
        }
    }
}
