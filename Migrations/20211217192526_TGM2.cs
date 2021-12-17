using Microsoft.EntityFrameworkCore.Migrations;

namespace Csharp_Belt.Migrations
{
    public partial class TGM2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationInHours",
                table: "Activities");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Activities",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "Activities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "timeUnit",
                table: "Activities",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "timeUnit",
                table: "Activities");

            migrationBuilder.AddColumn<int>(
                name: "DurationInHours",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
