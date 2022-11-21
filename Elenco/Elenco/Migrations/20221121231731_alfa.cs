using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elenco.Migrations
{
    public partial class alfa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Autenticidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autenticidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Origem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Origem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elenco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Retrato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrigemId = table.Column<int>(type: "int", nullable: true),
                    ExperienciaAlfaId = table.Column<int>(type: "int", nullable: true),
                    ExperienciaBetaId = table.Column<int>(type: "int", nullable: true),
                    AutenticidadeAlfaId = table.Column<int>(type: "int", nullable: true),
                    AutenticidadeBetaId = table.Column<int>(type: "int", nullable: true),
                    AutenticidadeGamaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elenco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elenco_Autenticidade_AutenticidadeAlfaId",
                        column: x => x.AutenticidadeAlfaId,
                        principalTable: "Autenticidade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Elenco_Autenticidade_AutenticidadeBetaId",
                        column: x => x.AutenticidadeBetaId,
                        principalTable: "Autenticidade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Elenco_Autenticidade_AutenticidadeGamaId",
                        column: x => x.AutenticidadeGamaId,
                        principalTable: "Autenticidade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Elenco_Experiencia_ExperienciaAlfaId",
                        column: x => x.ExperienciaAlfaId,
                        principalTable: "Experiencia",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Elenco_Experiencia_ExperienciaBetaId",
                        column: x => x.ExperienciaBetaId,
                        principalTable: "Experiencia",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Elenco_Origem_OrigemId",
                        column: x => x.OrigemId,
                        principalTable: "Origem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Elenco_AutenticidadeAlfaId",
                table: "Elenco",
                column: "AutenticidadeAlfaId");

            migrationBuilder.CreateIndex(
                name: "IX_Elenco_AutenticidadeBetaId",
                table: "Elenco",
                column: "AutenticidadeBetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Elenco_AutenticidadeGamaId",
                table: "Elenco",
                column: "AutenticidadeGamaId");

            migrationBuilder.CreateIndex(
                name: "IX_Elenco_ExperienciaAlfaId",
                table: "Elenco",
                column: "ExperienciaAlfaId");

            migrationBuilder.CreateIndex(
                name: "IX_Elenco_ExperienciaBetaId",
                table: "Elenco",
                column: "ExperienciaBetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Elenco_OrigemId",
                table: "Elenco",
                column: "OrigemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elenco");

            migrationBuilder.DropTable(
                name: "Autenticidade");

            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.DropTable(
                name: "Origem");
        }
    }
}
