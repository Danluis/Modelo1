using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DANLUIS_AP1_P1.Migrations
{
    /// <inheritdoc />
    public partial class AgregarCampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Modelo1s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Modelo1s",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Modelo1s");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Modelo1s");
        }
    }
}
