using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportCodes.Migrations
{
    public partial class UpdateFloridaState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "State",
                value: "Florida");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6,
                column: "State",
                value: "California");
        }
    }
}
