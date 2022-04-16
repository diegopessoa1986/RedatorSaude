using Microsoft.EntityFrameworkCore.Migrations;

namespace RedatorSaude.Data.Migrations
{
    public partial class newDocument : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vara = table.Column<string>(nullable: true),
                    Foro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    NumeroProcesso = table.Column<string>(nullable: true),
                    Autor = table.Column<string>(nullable: true),
                    Reu = table.Column<string>(nullable: true),
                    DataCriacao = table.Column<string>(nullable: true),
                    NomePeca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");
        }
    }
}
