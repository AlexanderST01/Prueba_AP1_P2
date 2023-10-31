using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Prueba_AP1_P2.Server.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entradas",
                columns: table => new
                {
                    EntradaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Concepto = table.Column<string>(type: "TEXT", nullable: false),
                    PesoTotal = table.Column<double>(type: "REAL", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadProducida = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entradas", x => x.EntradaId);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                    Existencia = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.ProductoId);
                });

            migrationBuilder.CreateTable(
                name: "EntredasDetalles",
                columns: table => new
                {
                    DetalleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EntradaId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductoId = table.Column<int>(type: "INTEGER", nullable: false),
                    CantidadUtilizada = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntredasDetalles", x => x.DetalleId);
                    table.ForeignKey(
                        name: "FK_EntredasDetalles_Entradas_EntradaId",
                        column: x => x.EntradaId,
                        principalTable: "Entradas",
                        principalColumn: "EntradaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "ProductoId", "Descripcion", "Existencia", "Tipo" },
                values: new object[,]
                {
                    { 1, "Maní", 40, 0 },
                    { 2, "Pistachos", 600, 0 },
                    { 3, "Pasas", 500, 0 },
                    { 4, "Ciruelas", 700, 0 },
                    { 5, "Mixto MPP 0.5lb", 0, 1 },
                    { 6, "Mixto MPC 0.5lb", 0, 1 },
                    { 7, "Mixto MPP 0.2lb", 0, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EntredasDetalles_EntradaId",
                table: "EntredasDetalles",
                column: "EntradaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntredasDetalles");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "Entradas");
        }
    }
}
