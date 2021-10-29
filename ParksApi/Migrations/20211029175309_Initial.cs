using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportCodes.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255) CHARACTER SET utf8mb4", nullable: false),
                    UserName = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    PasswordString = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    PostedRating = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    SecurityStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    State = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Area = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Visitors = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    YearEstablished = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Area", "Description", "Name", "State", "Visitors", "YearEstablished" },
                values: new object[,]
                {
                    { 1, "49,076.63 acres (198.6 km2)", "Covering most of Mount Desert Island and other coastal islands, Acadia features the tallest mountain on the Atlantic coast of the United States, granite peaks, ocean shoreline, woodlands, and lakes. There are freshwater, estuary, forest, and intertidal habitats.", "Acadia", "Maine", "2,669,034", "1919" },
                    { 2, "242,755.94 acres (982.4 km2)", "The Badlands are a collection of buttes, pinnacles, spires, and mixed-grass prairies. The White River Badlands contain the largest assemblage of known late Eocene and Oligocene mammal fossils. The wildlife includes bison, bighorn sheep, black-footed ferrets, and prairie dogs.", "Badlands", "South Dakota", "916,932", "1978" },
                    { 3, "183,224.05 acres (741.5 km2)", "Crater Lake lies in the caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago. The lake is the deepest in the United States and is noted for its vivid blue color and water clarity. Wizard Island and the Phantom Ship are more recent volcanic formations within the caldera. As the lake has no inlets or outlets, it is replenished only by precipitation.", "Crater Lake", "Oregon", "670,500", "1902" },
                    { 4, "64,701.22 acres (261.8 km2)", "The islands of the Dry Tortugas, at the westernmost end of the Florida Keys, are the site of Fort Jefferson, a Civil War-era fort that is the largest masonry structure in the Western Hemisphere. The park is home to undisturbed coral reefs and shipwrecks, and is only accessible by plane or boat.", "Dry Tortugas", "Florida", "48,543", "1992" },
                    { 5, "761,747.50 acres (3,082.7 km2)", "3	Yosemite features sheer granite cliffs, exceptionally tall waterfalls, and old-growth forests at a unique intersection of geology and hydrology. Half Dome and El Capitan rise from the park's centerpiece, the glacier-carved Yosemite Valley, and from its vertical walls drop Yosemite Falls, one of North America's tallest waterfalls at 2,425 feet (739 m) high. Three giant sequoia groves, along with a pristine wilderness in the heart of the Sierra Nevada, are home to a wide variety of rare plant and animal species", "Yosemite", "California", "2,268,313", "1890" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
