using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dt191g_moment32.Migrations
{
    public partial class LoanStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LoanStatus",
                table: "Cd",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoanStatus",
                table: "Cd");
        }
    }
}
