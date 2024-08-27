using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasperAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adscripciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(60)", nullable: false),
                    Siglas = table.Column<string>(type: "varchar(10)", nullable: false),
                    EmpleadoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adscripciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nombres = table.Column<string>(type: "varchar(80)", nullable: false),
                    PrimerApellido = table.Column<string>(type: "varchar(80)", nullable: false),
                    SegundoApellido = table.Column<string>(type: "varchar(80)", nullable: true),
                    FechaDeNacimiento = table.Column<DateOnly>(type: "date", nullable: false),
                    CURP = table.Column<string>(type: "nvarchar(18)", nullable: false),
                    Email = table.Column<string>(type: "varchar(60)", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(500)", nullable: true),
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
                        onDelete: ReferentialAction.Restrict,
                        onUpdate:ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_AdscripcionId",
                table: "Empleados",
                column: "AdscripcionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Adscripciones");
        }
    }
}
