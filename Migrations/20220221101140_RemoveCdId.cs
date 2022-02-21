using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dt191g_moment32.Migrations
{
    public partial class RemoveCdId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoanId",
                table: "Cd");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LoanId",
                table: "Cd",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
