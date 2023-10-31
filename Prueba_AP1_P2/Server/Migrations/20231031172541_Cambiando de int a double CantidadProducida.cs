using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_AP1_P2.Server.Migrations
{
    /// <inheritdoc />
    public partial class CambiandodeintadoubleCantidadProducida : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "CantidadProducida",
                table: "Entradas",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CantidadProducida",
                table: "Entradas",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "REAL");
        }
    }
}
