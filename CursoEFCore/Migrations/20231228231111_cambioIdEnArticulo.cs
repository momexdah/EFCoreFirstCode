using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoEFCore.Migrations
{
    public partial class cambioIdEnArticulo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ArticuloId",
                table: "Tbl_Articulos",
                newName: "Articulo_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Articulo_Id",
                table: "Tbl_Articulos",
                newName: "ArticuloId");
        }
    }
}
