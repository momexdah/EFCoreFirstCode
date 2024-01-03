using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursoEFCore.Migrations
{
    public partial class FKCateogoriaArticuloBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categorias",
                newName: "Categoria_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tbl_Articulos",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Categoria_Id",
                table: "Tbl_Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Articulos_Categoria_Id",
                table: "Tbl_Articulos",
                column: "Categoria_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Articulos_Categorias_Categoria_Id",
                table: "Tbl_Articulos",
                column: "Categoria_Id",
                principalTable: "Categorias",
                principalColumn: "Categoria_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Articulos_Categorias_Categoria_Id",
                table: "Tbl_Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Articulos_Categoria_Id",
                table: "Tbl_Articulos");

            migrationBuilder.DropColumn(
                name: "Categoria_Id",
                table: "Tbl_Articulos");

            migrationBuilder.RenameColumn(
                name: "Categoria_Id",
                table: "Categorias",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tbl_Articulos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);
        }
    }
}
