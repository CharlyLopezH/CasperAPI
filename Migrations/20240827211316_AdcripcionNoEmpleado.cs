using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CasperAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdcripcionNoEmpleado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Adscripciones");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Adscripciones",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
