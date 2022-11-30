using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SWPharmacy.Migrations
{
    public partial class v7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPagamento",
                table: "Vendas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoPagamento",
                table: "Vendas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
