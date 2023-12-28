using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoEFCore.Migrations
{
    public partial class CampoEdadUsuarioNoMapeadoYDireccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Usuarios");
        }
    }
}
