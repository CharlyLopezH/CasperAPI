using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasperAPI.Migrations
{
    /// <inheritdoc />
    public partial class InicialAdscripEmpChek : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adscripciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Siglas = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adscripciones", x => x.Id);
                });
            // Agregar el índice único
            migrationBuilder.CreateIndex(
                name: "IX_Adscrip_Codigo",
                table: "Adscripciones",
                column: "Siglas",
                unique: true);

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    FechaDeNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    CURP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AdscripcionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empleados_Adscripciones_AdscripcionId",
                        column: x => x.AdscripcionId,
                        principalTable: "Adscripciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
            // Agregar el índice único
            migrationBuilder.CreateIndex(
                name: "IX_Empleados_Codigo",
                table: "Empleados",
                column: "Codigo",
                unique: true);

            migrationBuilder.CreateTable(
                name: "Checadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false).Annotation("SqlServer:Identity", "1, 1"),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false),
                    FechaHoraChecada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dispositivo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Checadas_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.CreateIndex(
                name: "IX_Checadas_EmpleadoId",
                table: "Checadas",
                column: "EmpleadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_AdscripcionId",
                table: "Empleados",
                column: "AdscripcionId");

            // Agregar el índice compuesto único
            migrationBuilder.CreateIndex(
                name: "IX_Checadas_EmpleadoId_FechaHoraChkd",
                table: "Checadas",
                columns: new[] { "EmpleadoId", "FechaHoraChecada" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checadas");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Adscripciones");
        }
    }
}
