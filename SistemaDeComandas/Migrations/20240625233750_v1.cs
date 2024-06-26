using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeComandas.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComandaItems_Comandas_ComandaId1",
                table: "ComandaItems");

            migrationBuilder.DropForeignKey(
                name: "FK_PedidoCozinhaItems_PedidoCozinhas_PedidoCozinhaId1",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropIndex(
                name: "IX_PedidoCozinhaItems_PedidoCozinhaId1",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropIndex(
                name: "IX_ComandaItems_ComandaId1",
                table: "ComandaItems");

            migrationBuilder.DropColumn(
                name: "PedidoCozinhaId1",
                table: "PedidoCozinhaItems");

            migrationBuilder.DropColumn(
                name: "ComandaId1",
                table: "ComandaItems");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Senha = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "PedidoCozinhaId1",
                table: "PedidoCozinhaItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ComandaId1",
                table: "ComandaItems",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinhaItems_PedidoCozinhaId1",
                table: "PedidoCozinhaItems",
                column: "PedidoCozinhaId1");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaItems_ComandaId1",
                table: "ComandaItems",
                column: "ComandaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ComandaItems_Comandas_ComandaId1",
                table: "ComandaItems",
                column: "ComandaId1",
                principalTable: "Comandas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidoCozinhaItems_PedidoCozinhas_PedidoCozinhaId1",
                table: "PedidoCozinhaItems",
                column: "PedidoCozinhaId1",
                principalTable: "PedidoCozinhas",
                principalColumn: "Id");
        }
    }
}
