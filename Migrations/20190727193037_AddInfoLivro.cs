using Microsoft.EntityFrameworkCore.Migrations;

namespace Livraria.Migrations
{
    public partial class AddInfoLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Autor",
                table: "Livros",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Livros",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Autor",
                table: "Livros");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Livros");
        }
    }
}
