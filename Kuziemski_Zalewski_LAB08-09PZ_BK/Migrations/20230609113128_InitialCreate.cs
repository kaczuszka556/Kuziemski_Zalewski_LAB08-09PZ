using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kuziemski_Zalewski_LAB08_09PZ_BK.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Preferencjes",
                columns: table => new
                {
                    PreferencjeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Jezyk = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferencjes", x => x.PreferencjeId);
                });

            migrationBuilder.CreateTable(
                name: "Wydarzenia",
                columns: table => new
                {
                    WydarzenieId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    Opis = table.Column<string>(type: "TEXT", nullable: false),
                    Poczatek = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Koniec = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wydarzenia", x => x.WydarzenieId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Preferencjes");

            migrationBuilder.DropTable(
                name: "Wydarzenia");
        }
    }
}
