using Microsoft.EntityFrameworkCore.Migrations;

namespace Superhero_Proj.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlterEgoName",
                table: "Superheroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Catchphrase",
                table: "Superheroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimaryAbility",
                table: "Superheroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondaryAbility",
                table: "Superheroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SuperheroName",
                table: "Superheroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlterEgoName",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "Catchphrase",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "PrimaryAbility",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "SecondaryAbility",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "SuperheroName",
                table: "Superheroes");
        }
    }
}
