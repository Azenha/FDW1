using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NpcManager.Migrations
{
    public partial class Primeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeDoisId",
                table: "Npc");

            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeTresId",
                table: "Npc");

            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeUmId",
                table: "Npc");

            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Experiencia_ExperienciaDoisId",
                table: "Npc");

            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Experiencia_ExperienciaUmId",
                table: "Npc");

            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Origem_OrigemId",
                table: "Npc");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Origem",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Retrato",
                table: "Npc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "OrigemId",
                table: "Npc",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ExperienciaUmId",
                table: "Npc",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ExperienciaDoisId",
                table: "Npc",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Npc",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AutenticidadeUmId",
                table: "Npc",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AutenticidadeTresId",
                table: "Npc",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AutenticidadeDoisId",
                table: "Npc",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Experiencia",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Autenticidade",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeDoisId",
                table: "Npc",
                column: "AutenticidadeDoisId",
                principalTable: "Autenticidade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeTresId",
                table: "Npc",
                column: "AutenticidadeTresId",
                principalTable: "Autenticidade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeUmId",
                table: "Npc",
                column: "AutenticidadeUmId",
                principalTable: "Autenticidade",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Experiencia_ExperienciaDoisId",
                table: "Npc",
                column: "ExperienciaDoisId",
                principalTable: "Experiencia",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Experiencia_ExperienciaUmId",
                table: "Npc",
                column: "ExperienciaUmId",
                principalTable: "Experiencia",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Origem_OrigemId",
                table: "Npc",
                column: "OrigemId",
                principalTable: "Origem",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeDoisId",
                table: "Npc");

            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeTresId",
                table: "Npc");

            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeUmId",
                table: "Npc");

            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Experiencia_ExperienciaDoisId",
                table: "Npc");

            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Experiencia_ExperienciaUmId",
                table: "Npc");

            migrationBuilder.DropForeignKey(
                name: "FK_Npc_Origem_OrigemId",
                table: "Npc");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Origem",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Retrato",
                table: "Npc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrigemId",
                table: "Npc",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExperienciaUmId",
                table: "Npc",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExperienciaDoisId",
                table: "Npc",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Npc",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AutenticidadeUmId",
                table: "Npc",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AutenticidadeTresId",
                table: "Npc",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AutenticidadeDoisId",
                table: "Npc",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Experiencia",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Autenticidade",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeDoisId",
                table: "Npc",
                column: "AutenticidadeDoisId",
                principalTable: "Autenticidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeTresId",
                table: "Npc",
                column: "AutenticidadeTresId",
                principalTable: "Autenticidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Autenticidade_AutenticidadeUmId",
                table: "Npc",
                column: "AutenticidadeUmId",
                principalTable: "Autenticidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Experiencia_ExperienciaDoisId",
                table: "Npc",
                column: "ExperienciaDoisId",
                principalTable: "Experiencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Experiencia_ExperienciaUmId",
                table: "Npc",
                column: "ExperienciaUmId",
                principalTable: "Experiencia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Npc_Origem_OrigemId",
                table: "Npc",
                column: "OrigemId",
                principalTable: "Origem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
