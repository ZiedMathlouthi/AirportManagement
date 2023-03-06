using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class discriminator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EmployementDate",
                table: "Passengers",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Function",
                table: "Passengers",
                type: "varchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsTraveller",
                table: "Passengers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Salary",
                table: "Passengers",
                type: "real",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployementDate",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "Function",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "IsTraveller",
                table: "Passengers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Passengers");
        }
    }
}
