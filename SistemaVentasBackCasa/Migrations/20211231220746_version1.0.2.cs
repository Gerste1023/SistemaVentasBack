using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasBackCasa.Migrations
{
    public partial class version102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Rol",
                table: "Usuarios",
                newName: "RolId");

            migrationBuilder.AlterColumn<string>(
                name: "TipoRol",
                table: "Roles",
                type: "varchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RolId",
                table: "Usuarios",
                newName: "Rol");

            migrationBuilder.AlterColumn<string>(
                name: "TipoRol",
                table: "Roles",
                type: "varchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)");
        }
    }
}
