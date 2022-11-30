using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWPharmacy.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Clientes_ClientesId",
                table: "Vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Produtos_ProdutosId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_ClientesId",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_ProdutosId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "ClientesId",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "ProdutosId",
                table: "Vendas");

            migrationBuilder.AddColumn<int>(
                name: "ClienteID",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProdutoID",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClienteID",
                table: "Vendas",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ProdutoID",
                table: "Vendas",
                column: "ProdutoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Clientes_ClienteID",
                table: "Vendas",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Produtos_ProdutoID",
                table: "Vendas",
                column: "ProdutoID",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Clientes_ClienteID",
                table: "Vendas");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Produtos_ProdutoID",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_ClienteID",
                table: "Vendas");

            migrationBuilder.DropIndex(
                name: "IX_Vendas_ProdutoID",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "ClienteID",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "ProdutoID",
                table: "Vendas");

            migrationBuilder.AddColumn<int>(
                name: "ClientesId",
                table: "Vendas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProdutosId",
                table: "Vendas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClientesId",
                table: "Vendas",
                column: "ClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ProdutosId",
                table: "Vendas",
                column: "ProdutosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Clientes_ClientesId",
                table: "Vendas",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Produtos_ProdutosId",
                table: "Vendas",
                column: "ProdutosId",
                principalTable: "Produtos",
                principalColumn: "Id");
        }
    }
}
