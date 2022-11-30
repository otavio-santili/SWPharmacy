using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWPharmacy.Migrations
{
    public partial class v9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPagamentoID",
                table: "Vendas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoPagamentoID",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
