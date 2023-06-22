using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultorio.Migrations
{
    /// <inheritdoc />
    public partial class ConsultaInicial03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EspecialidadeId",
                table: "tb_Consulta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "profissionalId",
                table: "tb_Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Consulta_EspecialidadeId",
                table: "tb_Consulta",
                column: "EspecialidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Consulta_profissionalId",
                table: "tb_Consulta",
                column: "profissionalId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Consulta_tb_especialidade_EspecialidadeId",
                table: "tb_Consulta",
                column: "EspecialidadeId",
                principalTable: "tb_especialidade",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Consulta_tb_profissional_profissionalId",
                table: "tb_Consulta",
                column: "profissionalId",
                principalTable: "tb_profissional",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Consulta_tb_especialidade_EspecialidadeId",
                table: "tb_Consulta");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Consulta_tb_profissional_profissionalId",
                table: "tb_Consulta");

            migrationBuilder.DropIndex(
                name: "IX_tb_Consulta_EspecialidadeId",
                table: "tb_Consulta");

            migrationBuilder.DropIndex(
                name: "IX_tb_Consulta_profissionalId",
                table: "tb_Consulta");

            migrationBuilder.DropColumn(
                name: "EspecialidadeId",
                table: "tb_Consulta");

            migrationBuilder.DropColumn(
                name: "profissionalId",
                table: "tb_Consulta");
        }
    }
}
