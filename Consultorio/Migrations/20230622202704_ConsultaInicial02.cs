using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultorio.Migrations
{
    /// <inheritdoc />
    public partial class ConsultaInicial02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pacienteId",
                table: "tb_Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_Consulta_pacienteId",
                table: "tb_Consulta",
                column: "pacienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Consulta_tb_paciente_pacienteId",
                table: "tb_Consulta",
                column: "pacienteId",
                principalTable: "tb_paciente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Consulta_tb_paciente_pacienteId",
                table: "tb_Consulta");

            migrationBuilder.DropIndex(
                name: "IX_tb_Consulta_pacienteId",
                table: "tb_Consulta");

            migrationBuilder.DropColumn(
                name: "pacienteId",
                table: "tb_Consulta");
        }
    }
}
