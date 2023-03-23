using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmeAPI.Migrations
{
    /// <inheritdoc />
    public partial class TerceiraCriacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublicacaoId",
                table: "Interacoes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_UsuarioId",
                table: "Interacoes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Interacoes__UsuarioId",
                table: "Interacoes",
                column: "_UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Interacoes_PublicacaoId",
                table: "Interacoes",
                column: "PublicacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interacoes_Publicacoes_PublicacaoId",
                table: "Interacoes",
                column: "PublicacaoId",
                principalTable: "Publicacoes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interacoes_Usuarios__UsuarioId",
                table: "Interacoes",
                column: "_UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interacoes_Publicacoes_PublicacaoId",
                table: "Interacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Interacoes_Usuarios__UsuarioId",
                table: "Interacoes");

            migrationBuilder.DropIndex(
                name: "IX_Interacoes__UsuarioId",
                table: "Interacoes");

            migrationBuilder.DropIndex(
                name: "IX_Interacoes_PublicacaoId",
                table: "Interacoes");

            migrationBuilder.DropColumn(
                name: "PublicacaoId",
                table: "Interacoes");

            migrationBuilder.DropColumn(
                name: "_UsuarioId",
                table: "Interacoes");
        }
    }
}
