﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeComandas.Migrations
{
    /// <inheritdoc />
    public partial class Primeira_Migracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardapioItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titulo = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    Preco = table.Column<decimal>(type: "TEXT", nullable: false),
                    PossuiPreparo = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardapioItems", x => x.Id);
                },
                comment: "Cadastro de items do cardapio");

            migrationBuilder.CreateTable(
                name: "Comandas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroMesa = table.Column<int>(type: "INTEGER", nullable: false),
                    NomeCliente = table.Column<string>(type: "TEXT", nullable: false),
                    SituacaoComanda = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comandas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroMesa = table.Column<int>(type: "INTEGER", nullable: false),
                    SituacaoMesa = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PedidoCozinhas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ComandaId = table.Column<int>(type: "INTEGER", nullable: false),
                    SituacaoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoCozinhas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComandaItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CardapioItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    ComandaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ComandaId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandaItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComandaItems_CardapioItems_CardapioItemId",
                        column: x => x.CardapioItemId,
                        principalTable: "CardapioItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComandaItems_Comandas_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "Comandas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ComandaItems_Comandas_ComandaId1",
                        column: x => x.ComandaId1,
                        principalTable: "Comandas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PedidoCozinhaItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PedidoCozinhaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ComandaItemId = table.Column<int>(type: "INTEGER", nullable: false),
                    PedidoCozinhaId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidoCozinhaItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidoCozinhaItems_ComandaItems_ComandaItemId",
                        column: x => x.ComandaItemId,
                        principalTable: "ComandaItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoCozinhaItems_PedidoCozinhas_PedidoCozinhaId",
                        column: x => x.PedidoCozinhaId,
                        principalTable: "PedidoCozinhas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidoCozinhaItems_PedidoCozinhas_PedidoCozinhaId1",
                        column: x => x.PedidoCozinhaId1,
                        principalTable: "PedidoCozinhas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComandaItems_CardapioItemId",
                table: "ComandaItems",
                column: "CardapioItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaItems_ComandaId",
                table: "ComandaItems",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_ComandaItems_ComandaId1",
                table: "ComandaItems",
                column: "ComandaId1");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinhaItems_ComandaItemId",
                table: "PedidoCozinhaItems",
                column: "ComandaItemId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinhaItems_PedidoCozinhaId",
                table: "PedidoCozinhaItems",
                column: "PedidoCozinhaId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidoCozinhaItems_PedidoCozinhaId1",
                table: "PedidoCozinhaItems",
                column: "PedidoCozinhaId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropTable(
                name: "PedidoCozinhaItems");

            migrationBuilder.DropTable(
                name: "ComandaItems");

            migrationBuilder.DropTable(
                name: "PedidoCozinhas");

            migrationBuilder.DropTable(
                name: "CardapioItems");

            migrationBuilder.DropTable(
                name: "Comandas");
        }
    }
}
