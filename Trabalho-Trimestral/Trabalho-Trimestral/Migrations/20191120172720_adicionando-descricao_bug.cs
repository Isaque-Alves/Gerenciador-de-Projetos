using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho_Trimestral.Migrations
{
    public partial class adicionandodescricao_bug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Desenvolvedores_DesenvolvedorSolucionadorId",
                table: "Bugs");

            migrationBuilder.AlterColumn<int>(
                name: "DesenvolvedorSolucionadorId",
                table: "Bugs",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Bugs",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Desenvolvedores_DesenvolvedorSolucionadorId",
                table: "Bugs",
                column: "DesenvolvedorSolucionadorId",
                principalTable: "Desenvolvedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Desenvolvedores_DesenvolvedorSolucionadorId",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Bugs");

            migrationBuilder.AlterColumn<int>(
                name: "DesenvolvedorSolucionadorId",
                table: "Bugs",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Desenvolvedores_DesenvolvedorSolucionadorId",
                table: "Bugs",
                column: "DesenvolvedorSolucionadorId",
                principalTable: "Desenvolvedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
