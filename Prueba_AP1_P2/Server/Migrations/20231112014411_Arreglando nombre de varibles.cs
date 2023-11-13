using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_AP1_P2.Server.Migrations
{
    /// <inheritdoc />
    public partial class Arreglandonombredevaribles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntredasDetalles_Entradas_EntradaId",
                table: "EntredasDetalles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntredasDetalles",
                table: "EntredasDetalles");

            migrationBuilder.RenameTable(
                name: "EntredasDetalles",
                newName: "EntradasDetalles");

            migrationBuilder.RenameIndex(
                name: "IX_EntredasDetalles_EntradaId",
                table: "EntradasDetalles",
                newName: "IX_EntradasDetalles_EntradaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntradasDetalles",
                table: "EntradasDetalles",
                column: "DetalleId");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Existencia",
                value: 40000.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "Existencia",
                value: 60000.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "Existencia",
                value: 50000.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "Existencia",
                value: 70000.0);

            migrationBuilder.AddForeignKey(
                name: "FK_EntradasDetalles_Entradas_EntradaId",
                table: "EntradasDetalles",
                column: "EntradaId",
                principalTable: "Entradas",
                principalColumn: "EntradaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EntradasDetalles_Entradas_EntradaId",
                table: "EntradasDetalles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EntradasDetalles",
                table: "EntradasDetalles");

            migrationBuilder.RenameTable(
                name: "EntradasDetalles",
                newName: "EntredasDetalles");

            migrationBuilder.RenameIndex(
                name: "IX_EntradasDetalles_EntradaId",
                table: "EntredasDetalles",
                newName: "IX_EntredasDetalles_EntradaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EntredasDetalles",
                table: "EntredasDetalles",
                column: "DetalleId");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 1,
                column: "Existencia",
                value: 4000.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 2,
                column: "Existencia",
                value: 6000.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 3,
                column: "Existencia",
                value: 5000.0);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "ProductoId",
                keyValue: 4,
                column: "Existencia",
                value: 7000.0);

            migrationBuilder.AddForeignKey(
                name: "FK_EntredasDetalles_Entradas_EntradaId",
                table: "EntredasDetalles",
                column: "EntradaId",
                principalTable: "Entradas",
                principalColumn: "EntradaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
