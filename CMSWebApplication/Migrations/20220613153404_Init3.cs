using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSWebApplication.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Detail",
                table: "Notice",
                newName: "Absract");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Absract",
                table: "Notice",
                newName: "Detail");
        }
    }
}
