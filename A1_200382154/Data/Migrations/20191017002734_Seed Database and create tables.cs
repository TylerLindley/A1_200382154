using Microsoft.EntityFrameworkCore.Migrations;

namespace A1_200382154.Data.Migrations
{
    public partial class SeedDatabaseandcreatetables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Food",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeNameTypeId",
                table: "Food",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animal",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Animal",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TypeOfAnimal",
                columns: table => new
                {
                    TypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfAnimal", x => x.TypeId);
                });

            migrationBuilder.InsertData(
                table: "Animal",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 20, "He's GREAT", "Tyler The Tiger" },
                    { 21, "He Climbs Stuff", "Cody The Chipmunk" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "Brand", "Description", "Name", "NutritionalInformation", "Price", "TypeId", "TypeNameTypeId", "TypeOfAnimalFor", "Weight" },
                values: new object[,]
                {
                    { 24, "Petsy", "Average Dog Food", "Petsy Dog Food", "120 calories, full of vitamins A/B/C/D", 30m, 1, null, "Dog", 20m },
                    { 25, "Louis Vuitton", "Best Cat Caviar on the Market", "Louis Vuitton Cat Caviar", "1 Calorie, 0 Carbs, 0 Sugar, 0 fats", 4331m, 2, null, "Cat", 15m }
                });

            migrationBuilder.InsertData(
                table: "TypeOfAnimal",
                columns: new[] { "TypeId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Bark Bark!", "Dog" },
                    { 2, "Felines", "Cat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_TypeNameTypeId",
                table: "Food",
                column: "TypeNameTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Food_TypeOfAnimal_TypeNameTypeId",
                table: "Food",
                column: "TypeNameTypeId",
                principalTable: "TypeOfAnimal",
                principalColumn: "TypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Food_TypeOfAnimal_TypeNameTypeId",
                table: "Food");

            migrationBuilder.DropTable(
                name: "TypeOfAnimal");

            migrationBuilder.DropIndex(
                name: "IX_Food_TypeNameTypeId",
                table: "Food");

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Animal",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Food");

            migrationBuilder.DropColumn(
                name: "TypeNameTypeId",
                table: "Food");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

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
    }
}
