using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiraApp.Migrations
{
    /// <inheritdoc />
    public partial class v02_PrimeiraApp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmailConfirmacao",
                table: "Alunos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmailConfirmacao",
                table: "Alunos");
        }
    }
}
