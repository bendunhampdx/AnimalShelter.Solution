using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class catsAndDogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Breed", "Description", "Gender", "Name", "Weight" },
                values: new object[,]
                {
                    { 2, 4, "Bengal", "Fred is an easy going boy. He loves to lounge around with people and chase lasers.", "male", "Fred", 13 },
                    { 3, 2, "Siberian", "Lillie is an easy going gale. She loves to lounge around with people and chase lasers.", "female", "Lillie", 10 },
                    { 4, 9, "Ragdoll", "Barb is an easy going gale. She loves to lounge around with people and chase lasers.", "female", "Barb", 9 },
                    { 5, 12, "Siamese", "Rust is an easy going boy. He loves to lounge around with people and chase lasers.", "male", "Rust", 15 }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "Description", "Gender", "Name", "Weight" },
                values: new object[,]
                {
                    { 2, 3, "Lab", "Ollie is a fun loving pup with a lot of energy.", "female", "Ollie", 42 },
                    { 3, 6, "Pit-Bull", "Indigo is a fun loving pup with a lot of energy.", "male", "Indigo", 35 },
                    { 4, 9, "Corgi", "Kermit is a fun loving pup with a lot of energy.", "female", "Kermit", 24 },
                    { 5, 2, "Austrailian-Sheppard", "Danzig is a fun loving pup with a lot of energy.", "male", "Danzig", 26 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5);
        }
    }
}
