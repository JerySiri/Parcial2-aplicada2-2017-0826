using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial2_aplicada2_2017_0826.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombres = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "Cobros",
                columns: table => new
                {
                    cobroId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    clienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalPagados = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalCobros = table.Column<double>(type: "REAL", nullable: false),
                    observaciones = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobros", x => x.cobroId);
                });

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    VentaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClienteId = table.Column<int>(type: "INTEGER", nullable: false),
                    Monto = table.Column<double>(type: "REAL", nullable: false),
                    Balance = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.VentaId);
                });

            migrationBuilder.CreateTable(
                name: "CobrosDetalle",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    cobroId = table.Column<int>(type: "INTEGER", nullable: false),
                    ventaId = table.Column<int>(type: "INTEGER", nullable: false),
                    cobrado = table.Column<double>(type: "REAL", nullable: false),
                    fuePagado = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CobrosDetalle", x => x.id);
                    table.ForeignKey(
                        name: "FK_CobrosDetalle_Cobros_cobroId",
                        column: x => x.cobroId,
                        principalTable: "Cobros",
                        principalColumn: "cobroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Nombres" },
                values: new object[] { 1, "FERRETERIA GAMA" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Nombres" },
                values: new object[] { 2, "AVALON DISCO" });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "ClienteId", "Nombres" },
                values: new object[] { 3, "PRESTAMOS CEFIPROD" });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "VentaId", "Balance", "ClienteId", "Fecha", "Monto" },
                values: new object[] { 1, 1000.0, 1, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000.0 });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "VentaId", "Balance", "ClienteId", "Fecha", "Monto" },
                values: new object[] { 2, 800.0, 1, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 900.0 });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "VentaId", "Balance", "ClienteId", "Fecha", "Monto" },
                values: new object[] { 3, 2000.0, 2, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000.0 });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "VentaId", "Balance", "ClienteId", "Fecha", "Monto" },
                values: new object[] { 4, 1800.0, 2, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1900.0 });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "VentaId", "Balance", "ClienteId", "Fecha", "Monto" },
                values: new object[] { 5, 3000.0, 3, new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000.0 });

            migrationBuilder.InsertData(
                table: "Ventas",
                columns: new[] { "VentaId", "Balance", "ClienteId", "Fecha", "Monto" },
                values: new object[] { 6, 1900.0, 3, new DateTime(2020, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2900.0 });

            migrationBuilder.CreateIndex(
                name: "IX_CobrosDetalle_cobroId",
                table: "CobrosDetalle",
                column: "cobroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "CobrosDetalle");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropTable(
                name: "Cobros");
        }
    }
}
