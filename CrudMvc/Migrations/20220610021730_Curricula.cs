using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudMvc.Migrations
{
    public partial class Curricula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Curriculum");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Curriculum",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Curriculum",
                newName: "Genero");

            migrationBuilder.AlterColumn<decimal>(
                name: "Edad",
                table: "Curriculum",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Apellido",
                table: "Curriculum",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Apellido",
                table: "Curriculum");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Curriculum",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "Curriculum",
                newName: "Genre");

            migrationBuilder.AlterColumn<string>(
                name: "Edad",
                table: "Curriculum",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Curriculum",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
