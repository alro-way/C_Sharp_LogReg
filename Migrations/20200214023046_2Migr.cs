using Microsoft.EntityFrameworkCore.Migrations;

namespace C_Sharp_LogReg.Migrations
{
    public partial class _2Migr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Confirm",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirm",
                table: "Users");
        }
    }
}
