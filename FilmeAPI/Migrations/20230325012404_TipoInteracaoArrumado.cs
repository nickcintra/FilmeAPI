using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FilmeAPI.Migrations
{
    /// <inheritdoc />
    public partial class TipoInteracaoArrumado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipoInteracao",
                table: "Interacoes",
                newName: "tipoInteracaoid");

            migrationBuilder.CreateTable(
                name: "TipoInteracao",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipoInteracao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoInteracao", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Interacoes_tipoInteracaoid",
                table: "Interacoes",
                column: "tipoInteracaoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Interacoes_TipoInteracao_tipoInteracaoid",
                table: "Interacoes",
                column: "tipoInteracaoid",
                principalTable: "TipoInteracao",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interacoes_TipoInteracao_tipoInteracaoid",
                table: "Interacoes");

            migrationBuilder.DropTable(
                name: "TipoInteracao");

            migrationBuilder.DropIndex(
                name: "IX_Interacoes_tipoInteracaoid",
                table: "Interacoes");

            migrationBuilder.RenameColumn(
                name: "tipoInteracaoid",
                table: "Interacoes",
                newName: "tipoInteracao");
        }
    }
}
