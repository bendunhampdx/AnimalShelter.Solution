using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Breed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Description", "Gender", "Name", "Species", "Weight" },
                values: new object[,]
                {
                    { 1, 1, "Texas-Heeler", "Arlo is a fun loving pup with a lot of energy.", "male", "Arlo", "dog", 39 },
                    { 2, 3, "Lab", "Ollie is a fun loving pup with a lot of energy.", "female", "Ollie", "dog", 42 },
                    { 3, 6, "Pit-Bull", "Indigo is a fun loving pup with a lot of energy.", "male", "Indigo", "dog", 35 },
                    { 4, 9, "Corgi", "Kermit is a fun loving pup with a lot of energy.", "female", "Kermit", "dog", 24 },
                    { 5, 2, "Austrailian-Sheppard", "Danzig is a fun loving pup with a lot of energy.", "male", "Danzig", "dog", 26 },
                    { 6, 6, "Main coon", "Sam is an easy going boy. He loves to lounge around with people and chase lasers.", "male", "Sam", "cat", 15 },
                    { 7, 4, "Bengal", "Fred is an easy going boy. He loves to lounge around with people and chase lasers.", "male", "Fred", "cat", 13 },
                    { 8, 2, "Siberian", "Lillie is an easy going gale. She loves to lounge around with people and chase lasers.", "female", "Lillie", "cat", 10 },
                    { 9, 9, "Ragdoll", "Barb is an easy going gale. She loves to lounge around with people and chase lasers.", "female", "Barb", "cat", 9 },
                    { 10, 12, "Siamese", "Rust is an easy going boy. He loves to lounge around with people and chase lasers.", "male", "Rust", "cat", 15 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
