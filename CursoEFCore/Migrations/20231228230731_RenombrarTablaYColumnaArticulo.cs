using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoEFCore.Migrations
{
    public partial class RenombrarTablaYColumnaArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Articulos",
                table: "Articulos");

            migrationBuilder.RenameTable(
                name: "Articulos",
                newName: "Tbl_Articulos");

            migrationBuilder.RenameColumn(
                name: "TituloArticulo",
                table: "Tbl_Articulos",
                newName: "Titulo");

            migrationBuilder.AddColumn<string>(
                name: "Fecha",
                table: "Tbl_Articulos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Articulos",
                table: "Tbl_Articulos",
                column: "ArticuloId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Articulos",
                table: "Tbl_Articulos");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Tbl_Articulos");

            migrationBuilder.RenameTable(
                name: "Tbl_Articulos",
                newName: "Articulos");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Articulos",
                newName: "TituloArticulo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articulos",
                table: "Articulos",
                column: "ArticuloId");
        }
    }
}
