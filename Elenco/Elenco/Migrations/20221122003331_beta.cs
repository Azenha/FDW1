using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elenco.Migrations
{
    public partial class beta : Migration
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
                name: "Coadjuvante",
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
                    table.PrimaryKey("PK_Coadjuvante", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Coadjuvante_Autenticidade_AutenticidadeAlfaId",
                        column: x => x.AutenticidadeAlfaId,
                        principalTable: "Autenticidade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Coadjuvante_Autenticidade_AutenticidadeBetaId",
                        column: x => x.AutenticidadeBetaId,
                        principalTable: "Autenticidade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Coadjuvante_Autenticidade_AutenticidadeGamaId",
                        column: x => x.AutenticidadeGamaId,
                        principalTable: "Autenticidade",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Coadjuvante_Experiencia_ExperienciaAlfaId",
                        column: x => x.ExperienciaAlfaId,
                        principalTable: "Experiencia",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Coadjuvante_Experiencia_ExperienciaBetaId",
                        column: x => x.ExperienciaBetaId,
                        principalTable: "Experiencia",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Coadjuvante_Origem_OrigemId",
                        column: x => x.OrigemId,
                        principalTable: "Origem",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coadjuvante_AutenticidadeAlfaId",
                table: "Coadjuvante",
                column: "AutenticidadeAlfaId");

            migrationBuilder.CreateIndex(
                name: "IX_Coadjuvante_AutenticidadeBetaId",
                table: "Coadjuvante",
                column: "AutenticidadeBetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Coadjuvante_AutenticidadeGamaId",
                table: "Coadjuvante",
                column: "AutenticidadeGamaId");

            migrationBuilder.CreateIndex(
                name: "IX_Coadjuvante_ExperienciaAlfaId",
                table: "Coadjuvante",
                column: "ExperienciaAlfaId");

            migrationBuilder.CreateIndex(
                name: "IX_Coadjuvante_ExperienciaBetaId",
                table: "Coadjuvante",
                column: "ExperienciaBetaId");

            migrationBuilder.CreateIndex(
                name: "IX_Coadjuvante_OrigemId",
                table: "Coadjuvante",
                column: "OrigemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coadjuvante");

            migrationBuilder.DropTable(
                name: "Autenticidade");

            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.DropTable(
                name: "Origem");
        }
    }
}
