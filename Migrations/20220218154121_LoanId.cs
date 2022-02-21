using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dt191g_moment32.Migrations
{
    public partial class LoanId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LoanStatus",
                table: "Cd",
                newName: "LoanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LoanId",
                table: "Cd",
                newName: "LoanStatus");
        }
    }
}
