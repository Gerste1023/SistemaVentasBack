using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasBackCasa.Migrations
{
    public partial class version101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdCategoria",
                table: "Productos",
                newName: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Productos",
                newName: "IdCategoria");
        }
    }
}
