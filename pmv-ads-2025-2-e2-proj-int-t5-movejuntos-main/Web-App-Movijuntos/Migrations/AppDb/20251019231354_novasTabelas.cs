using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_App_Movijuntos.Migrations.AppDb
{
    /// <inheritdoc />
    public partial class novasTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locais",
                columns: table => new
                {
                    IdLocal = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locais", x => x.IdLocal);
                    table.ForeignKey(
                        name: "FK_Locais_Usuario_Id",
                        column: x => x.Id,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    IdAvaliacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nota = table.Column<int>(type: "int", nullable: false),
                    IdLocal = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.IdAvaliacao);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Locais_IdLocal",
                        column: x => x.IdLocal,
                        principalTable: "Locais",
                        principalColumn: "IdLocal",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Avaliacoes_Usuario_Id",
                        column: x => x.Id,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    IdComentario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAvaliacao = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.IdComentario);
                    table.ForeignKey(
                        name: "FK_Comentarios_Avaliacoes_IdAvaliacao",
                        column: x => x.IdAvaliacao,
                        principalTable: "Avaliacoes",
                        principalColumn: "IdAvaliacao",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuario_Id",
                        column: x => x.Id,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Criterios",
                columns: table => new
                {
                    IdCriterio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rampas = table.Column<bool>(type: "bit", nullable: false),
                    Corrimaos = table.Column<bool>(type: "bit", nullable: false),
                    BanheiroAcess = table.Column<bool>(type: "bit", nullable: false),
                    VagasEstacion = table.Column<bool>(type: "bit", nullable: false),
                    SinalizacaoTatil = table.Column<bool>(type: "bit", nullable: false),
                    SinalizacaoSonora = table.Column<bool>(type: "bit", nullable: false),
                    SinalizaçãoVisual = table.Column<bool>(type: "bit", nullable: false),
                    CaminhoLivre = table.Column<bool>(type: "bit", nullable: false),
                    PortasCorredor = table.Column<bool>(type: "bit", nullable: false),
                    IdAvaliacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criterios", x => x.IdCriterio);
                    table.ForeignKey(
                        name: "FK_Criterios_Avaliacoes_IdAvaliacao",
                        column: x => x.IdAvaliacao,
                        principalTable: "Avaliacoes",
                        principalColumn: "IdAvaliacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotos",
                columns: table => new
                {
                    IdFoto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    urlFoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAvaliacao = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotos", x => x.IdFoto);
                    table.ForeignKey(
                        name: "FK_Fotos_Avaliacoes_IdAvaliacao",
                        column: x => x.IdAvaliacao,
                        principalTable: "Avaliacoes",
                        principalColumn: "IdAvaliacao",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_Id",
                table: "Avaliacoes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacoes_IdLocal",
                table: "Avaliacoes",
                column: "IdLocal");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_Id",
                table: "Comentarios",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_IdAvaliacao",
                table: "Comentarios",
                column: "IdAvaliacao");

            migrationBuilder.CreateIndex(
                name: "IX_Criterios_IdAvaliacao",
                table: "Criterios",
                column: "IdAvaliacao");

            migrationBuilder.CreateIndex(
                name: "IX_Fotos_IdAvaliacao",
                table: "Fotos",
                column: "IdAvaliacao");

            migrationBuilder.CreateIndex(
                name: "IX_Locais_Id",
                table: "Locais",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Criterios");

            migrationBuilder.DropTable(
                name: "Fotos");

            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "Locais");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
