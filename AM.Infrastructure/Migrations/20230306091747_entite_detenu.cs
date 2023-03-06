using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class entite_detenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Passengers",
                newName: "FullName_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Passengers",
                newName: "FullName_FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "FullName_FirstName",
                table: "Passengers",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nchar(80)",
                oldMaxLength: 80,
                oldDefaultValue: "name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName_LastName",
                table: "Passengers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FullName_FirstName",
                table: "Passengers",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passengers",
                type: "nchar(80)",
                maxLength: 80,
                nullable: false,
                defaultValue: "name",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);
        }
    }
}
