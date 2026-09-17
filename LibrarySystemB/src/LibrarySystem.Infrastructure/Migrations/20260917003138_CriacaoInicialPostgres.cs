using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibrarySystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoInicialPostgres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "autores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    nome = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    nacionalidade = table.Column<string>(type: "character varying(80)", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_autores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "livros",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    titulo = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    autor_id = table.Column<Guid>(type: "uuid", nullable: false),
                    Isbn = table.Column<string>(type: "text", nullable: false),
                    categoria = table.Column<bool>(type: "boolean", nullable: false),
                    preco = table.Column<decimal>(type: "numeric(18,2)", precision: 18, scale: 2, nullable: false),
                    Categoria = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_livros", x => x.id);
                    table.ForeignKey(
                        name: "FK_livros_autores_autor_id",
                        column: x => x.autor_id,
                        principalTable: "autores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_livros_autor_id",
                table: "livros",
                column: "autor_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "livros");

            migrationBuilder.DropTable(
                name: "autores");
        }
    }
}
