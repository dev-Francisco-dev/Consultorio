using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Consultorio.Migrations
{
    /// <inheritdoc />
    public partial class ConsultaInicial05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Consulta_tb_especialidade_EspecialidadeId",
                table: "tb_Consulta");

            migrationBuilder.RenameColumn(
                name: "EspecialidadeId",
                table: "tb_Consulta",
                newName: "especialidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_Consulta_EspecialidadeId",
                table: "tb_Consulta",
                newName: "IX_tb_Consulta_especialidadeId");

            migrationBuilder.AlterColumn<int>(
                name: "especialidadeId",
                table: "tb_Consulta",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "tb_profissional_especialidade",
                columns: table => new
                {
                    id_profissional = table.Column<int>(type: "int", nullable: false),
                    id_especialidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_profissional_especialidade", x => new { x.id_profissional, x.id_especialidade });
                    table.ForeignKey(
                        name: "FK_tb_profissional_especialidade_tb_especialidade_id_especialidade",
                        column: x => x.id_especialidade,
                        principalTable: "tb_especialidade",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_profissional_especialidade_tb_profissional_id_profissional",
                        column: x => x.id_profissional,
                        principalTable: "tb_profissional",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_profissional_especialidade_id_especialidade",
                table: "tb_profissional_especialidade",
                column: "id_especialidade");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Consulta_tb_especialidade_especialidadeId",
                table: "tb_Consulta",
                column: "especialidadeId",
                principalTable: "tb_especialidade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Consulta_tb_especialidade_especialidadeId",
                table: "tb_Consulta");

            migrationBuilder.DropTable(
                name: "tb_profissional_especialidade");

            migrationBuilder.RenameColumn(
                name: "especialidadeId",
                table: "tb_Consulta",
                newName: "EspecialidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_tb_Consulta_especialidadeId",
                table: "tb_Consulta",
                newName: "IX_tb_Consulta_EspecialidadeId");

            migrationBuilder.AlterColumn<int>(
                name: "EspecialidadeId",
                table: "tb_Consulta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Consulta_tb_especialidade_EspecialidadeId",
                table: "tb_Consulta",
                column: "EspecialidadeId",
                principalTable: "tb_especialidade",
                principalColumn: "id");
        }
    }
}
