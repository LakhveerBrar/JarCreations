using Microsoft.EntityFrameworkCore.Migrations;

namespace JarCreations.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Jar");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Jar");

            migrationBuilder.AddColumn<string>(
                name: "Capacity",
                table: "Jar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Materials",
                table: "Jar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Jar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Jar",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Jar",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Jar");

            migrationBuilder.DropColumn(
                name: "Materials",
                table: "Jar");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Jar");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Jar");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Jar");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Jar",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Jar",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
