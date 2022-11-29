using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Protagonistas.Migrations
{
    public partial class primeiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ancestralidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ancestralidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Biografia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biografia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Caminho",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caminho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Retrato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AncestralidadeId = table.Column<int>(type: "int", nullable: true),
                    BiografiaId = table.Column<int>(type: "int", nullable: true),
                    CaminhoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personagem_Ancestralidade_AncestralidadeId",
                        column: x => x.AncestralidadeId,
                        principalTable: "Ancestralidade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personagem_Biografia_BiografiaId",
                        column: x => x.BiografiaId,
                        principalTable: "Biografia",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Personagem_Caminho_CaminhoId",
                        column: x => x.CaminhoId,
                        principalTable: "Caminho",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_AncestralidadeId",
                table: "Personagem",
                column: "AncestralidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_BiografiaId",
                table: "Personagem",
                column: "BiografiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Personagem_CaminhoId",
                table: "Personagem",
                column: "CaminhoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personagem");

            migrationBuilder.DropTable(
                name: "Ancestralidade");

            migrationBuilder.DropTable(
                name: "Biografia");

            migrationBuilder.DropTable(
                name: "Caminho");
        }
    }
}
