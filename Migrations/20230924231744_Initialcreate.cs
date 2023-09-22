using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPInvestigacion.Migrations
{
    /// <inheritdoc />
    public partial class Initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    patente = table.Column<string>(type: "TEXT", nullable: false),
                    marca = table.Column<string>(type: "TEXT", nullable: false),
                    modelo = table.Column<string>(type: "TEXT", nullable: false),
                    precio = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motos", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motos");
        }
    }
}
