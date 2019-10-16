using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_200382154.Data.Migrations
{
    public partial class SeedDataandcreatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 10, "He's GREAT", "Tyler The Tiger" },
                    { 11, "He Climbs Stuff", "Cody The Chipmunk" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "Brand", "Description", "Name", "NutritionalInformation", "Price", "TypeOfAnimalFor", "Weight" },
                values: new object[,]
                {
                    { 10, "Petsy", "Average Dog Food", "Petsy Dog Food", "120 calories, full of vitamins A/B/C/D", 30m, "Dog", 20m },
                    { 11, "Louis Vuitton", "Best Cat Caviar on the Market", "Louis Vuitton Cat Caviar", "1 Calorie, 0 Carbs, 0 Sugar, 0 fats", 4331m, "Cat", 15m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
