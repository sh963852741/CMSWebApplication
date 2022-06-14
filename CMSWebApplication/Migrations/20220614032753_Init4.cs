using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSWebApplication.Migrations
{
    public partial class Init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Notice",
                newName: "UpdatedOn");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Notice",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Display",
                table: "Notice",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiredOn",
                table: "Notice",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Importance",
                table: "Notice",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Notice");

            migrationBuilder.DropColumn(
                name: "Display",
                table: "Notice");

            migrationBuilder.DropColumn(
                name: "ExpiredOn",
                table: "Notice");

            migrationBuilder.DropColumn(
                name: "Importance",
                table: "Notice");

            migrationBuilder.RenameColumn(
                name: "UpdatedOn",
                table: "Notice",
                newName: "CreatedDate");
        }
    }
}
