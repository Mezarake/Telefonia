using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Planos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdPlano = table.Column<int>(nullable: false),
                    Minutos = table.Column<int>(nullable: false),
                    FranqInternet = table.Column<int>(nullable: false),
                    Valor = table.Column<int>(nullable: false),
                    TipoPlano = table.Column<string>(nullable: true),
                    Operadora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planos");
        }
    }
}
