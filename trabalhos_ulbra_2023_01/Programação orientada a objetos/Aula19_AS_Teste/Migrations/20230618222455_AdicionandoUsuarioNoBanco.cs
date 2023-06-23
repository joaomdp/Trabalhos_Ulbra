using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula19_AS_Teste
{
    /// <inheritdoc />
    public partial class AdicionandoUsuarioNoBanco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Livros_LivroId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Usuarios_UsuarioId",
                table: "Emprestimo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo");

            migrationBuilder.RenameTable(
                name: "Emprestimo",
                newName: "Emprestimos");

            migrationBuilder.RenameIndex(
                name: "IX_Emprestimo_UsuarioId",
                table: "Emprestimos",
                newName: "IX_Emprestimos_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Emprestimo_LivroId",
                table: "Emprestimos",
                newName: "IX_Emprestimos_LivroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emprestimos",
                table: "Emprestimos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimos_Livros_LivroId",
                table: "Emprestimos",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimos_Usuarios_UsuarioId",
                table: "Emprestimos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimos_Livros_LivroId",
                table: "Emprestimos");

            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimos_Usuarios_UsuarioId",
                table: "Emprestimos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emprestimos",
                table: "Emprestimos");

            migrationBuilder.RenameTable(
                name: "Emprestimos",
                newName: "Emprestimo");

            migrationBuilder.RenameIndex(
                name: "IX_Emprestimos_UsuarioId",
                table: "Emprestimo",
                newName: "IX_Emprestimo_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Emprestimos_LivroId",
                table: "Emprestimo",
                newName: "IX_Emprestimo_LivroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emprestimo",
                table: "Emprestimo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Livros_LivroId",
                table: "Emprestimo",
                column: "LivroId",
                principalTable: "Livros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Usuarios_UsuarioId",
                table: "Emprestimo",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
