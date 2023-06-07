using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula12_TestandoORM.Migrations
{
    /// <inheritdoc />
    public partial class AddCityHasManyPeopleAndOnePeopleHasOneCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cityId",
                table: "Persons",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "cities",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_cityId",
                table: "Persons",
                column: "cityId");

            migrationBuilder.CreateIndex(
                name: "IX_cities_CityId",
                table: "cities",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_cities_cities_CityId",
                table: "cities",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_cities_cityId",
                table: "Persons",
                column: "cityId",
                principalTable: "cities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cities_cities_CityId",
                table: "cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_cities_cityId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_cityId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_cities_CityId",
                table: "cities");

            migrationBuilder.DropColumn(
                name: "cityId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "cities");
        }
    }
}
