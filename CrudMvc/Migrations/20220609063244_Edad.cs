using Microsoft.EntityFrameworkCore.Migrations;

namespace CrudMvc.Migrations
{
    public partial class Edad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Edad",
                table: "Curriculum",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Edad",
                table: "Curriculum");
        }
    }
}
