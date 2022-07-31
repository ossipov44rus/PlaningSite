using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ZadachaFinal2.Migrations
{
    public partial class AddedBooleanIsDone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDone",
                table: "zad3",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDone",
                table: "zad2",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDone",
                table: "zad1",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDone",
                table: "zad3");

            migrationBuilder.DropColumn(
                name: "IsDone",
                table: "zad2");

            migrationBuilder.DropColumn(
                name: "IsDone",
                table: "zad1");
        }
    }
}
