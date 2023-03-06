using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class migration7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyPlanes",
                columns: table => new
                {
                    PlaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaneType = table.Column<int>(type: "int", nullable: false),
                    ManufactureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlaneCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyPlanes", x => x.PlaneId);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassportNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nchar(80)", maxLength: 80, nullable: false, defaultValue: "name"),
                    LastName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TelNumber = table.Column<int>(type: "int", nullable: true),
                    EmailAddress = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassportNumber);
                });

            migrationBuilder.CreateTable(
                name: "Vols",
                columns: table => new
                {
                    FlightId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedDuration = table.Column<int>(type: "int", nullable: false),
                    EffectiveArrival = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Departure = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Destination = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    PlaneFk = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vols", x => x.FlightId);
                    table.ForeignKey(
                        name: "FK_Vols_MyPlanes_PlaneFk",
                        column: x => x.PlaneFk,
                        principalTable: "MyPlanes",
                        principalColumn: "PlaneId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "MyReservations",
                columns: table => new
                {
                    FlightsFlightId = table.Column<int>(type: "int", nullable: false),
                    PassengersPassportNumber = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyReservations", x => new { x.FlightsFlightId, x.PassengersPassportNumber });
                    table.ForeignKey(
                        name: "FK_MyReservations_Passengers_PassengersPassportNumber",
                        column: x => x.PassengersPassportNumber,
                        principalTable: "Passengers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyReservations_Vols_FlightsFlightId",
                        column: x => x.FlightsFlightId,
                        principalTable: "Vols",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyReservations_PassengersPassportNumber",
                table: "MyReservations",
                column: "PassengersPassportNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Vols_PlaneFk",
                table: "Vols",
                column: "PlaneFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyReservations");

            migrationBuilder.DropTable(
                name: "Passengers");

            migrationBuilder.DropTable(
                name: "Vols");

            migrationBuilder.DropTable(
                name: "MyPlanes");
        }
    }
}
