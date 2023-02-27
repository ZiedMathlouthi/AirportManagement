using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPI5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vols_MyPlanes_PlaneId",
                table: "Vols");

            migrationBuilder.RenameColumn(
                name: "PlaneId",
                table: "Vols",
                newName: "PlaneFk");

            migrationBuilder.RenameIndex(
                name: "IX_Vols_PlaneId",
                table: "Vols",
                newName: "IX_Vols_PlaneFk");

            migrationBuilder.AddForeignKey(
                name: "FK_Vols_MyPlanes_PlaneFk",
                table: "Vols",
                column: "PlaneFk",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vols_MyPlanes_PlaneFk",
                table: "Vols");

            migrationBuilder.RenameColumn(
                name: "PlaneFk",
                table: "Vols",
                newName: "PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_Vols_PlaneFk",
                table: "Vols",
                newName: "IX_Vols_PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vols_MyPlanes_PlaneId",
                table: "Vols",
                column: "PlaneId",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
