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

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persons_cityId",
                table: "Persons",
                column: "cityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_City_cityId",
                table: "Persons",
                column: "cityId",
                principalTable: "City",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Persons_City_cityId",
                table: "Persons");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropIndex(
                name: "IX_Persons_cityId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "cityId",
                table: "Persons");
        }
    }
}
