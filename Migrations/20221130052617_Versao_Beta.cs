using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWPharmacy.Migrations
{
    public partial class Versao_Beta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendedoresId",
                table: "Vendas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_VendedoresId",
                table: "Vendas",
                column: "VendedoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Vendedores_VendedoresId",
                table: "Vendas",
                column: "VendedoresId",
                principalTable: "Vendedores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Vendedores_VendedoresId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_VendedoresId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "VendedoresId",
                table: "Vendas");
        }
    }
}
