using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWPharmacy.Migrations
{
    public partial class v8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoPagamento",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoPagamentoID",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPagamento",
                table: "Vendas");

            migrationBuilder.DropColumn(
                name: "TipoPagamentoID",
                table: "Vendas");
        }
    }
}
