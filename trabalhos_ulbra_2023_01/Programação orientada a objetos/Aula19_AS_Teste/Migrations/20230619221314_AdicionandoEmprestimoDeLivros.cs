using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula19_AS_Teste
{
    /// <inheritdoc />
    public partial class AdicionandoEmprestimoDeLivros : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Livros");

            migrationBuilder.AddColumn<bool>(
                name: "Emprestado",
                table: "Livros",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Emprestado",
                table: "Livros");

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Livros",
                type: "TEXT",
                nullable: true);
        }
    }
}
