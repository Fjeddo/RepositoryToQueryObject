using Microsoft.EntityFrameworkCore.Migrations;

namespace GarageApi.Business.Migrations
{
    public partial class GarageVehicleRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GarageId",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_GarageId",
                table: "Vehicles",
                column: "GarageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Garages_GarageId",
                table: "Vehicles",
                column: "GarageId",
                principalTable: "Garages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Garages_GarageId",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_GarageId",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "GarageId",
                table: "Vehicles");
        }
    }
}
