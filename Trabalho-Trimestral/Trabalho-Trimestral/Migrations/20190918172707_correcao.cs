using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho_Trimestral.Migrations
{
    public partial class correcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Requisitos_RequisitoId",
                table: "Bugs");

            migrationBuilder.RenameColumn(
                name: "DesenvolvedorSolucionador",
                table: "Bugs",
                newName: "DesenvolvedorSolucionadorId");

            migrationBuilder.AlterColumn<int>(
                name: "RequisitoId",
                table: "Bugs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Requisitos_RequisitoId",
                table: "Bugs",
                column: "RequisitoId",
                principalTable: "Requisitos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Requisitos_RequisitoId",
                table: "Bugs");

            migrationBuilder.RenameColumn(
                name: "DesenvolvedorSolucionadorId",
                table: "Bugs",
                newName: "DesenvolvedorSolucionador");

            migrationBuilder.AlterColumn<int>(
                name: "RequisitoId",
                table: "Bugs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Requisitos_RequisitoId",
                table: "Bugs",
                column: "RequisitoId",
                principalTable: "Requisitos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
