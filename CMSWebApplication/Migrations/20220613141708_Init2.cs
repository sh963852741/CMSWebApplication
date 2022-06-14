using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSWebApplication.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HtmlText",
                table: "Notice",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HtmlText",
                table: "Notice");
        }
    }
}
