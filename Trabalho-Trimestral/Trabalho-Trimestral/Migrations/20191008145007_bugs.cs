using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabalho_Trimestral.Migrations
{
    public partial class bugs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Bugs_DesenvolvedorSolucionadorId",
                table: "Bugs",
                column: "DesenvolvedorSolucionadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bugs_Desenvolvedores_DesenvolvedorSolucionadorId",
                table: "Bugs",
                column: "DesenvolvedorSolucionadorId",
                principalTable: "Desenvolvedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bugs_Desenvolvedores_DesenvolvedorSolucionadorId",
                table: "Bugs");

            migrationBuilder.DropIndex(
                name: "IX_Bugs_DesenvolvedorSolucionadorId",
                table: "Bugs");
        }
    }
}
