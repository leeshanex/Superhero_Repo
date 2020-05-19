using Microsoft.EntityFrameworkCore.Migrations;

namespace Superhero_Proj.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "alterEgoName",
                table: "Superheroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "catchphrase",
                table: "Superheroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primaryAbility",
                table: "Superheroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "secondaryAbility",
                table: "Superheroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "superheroName",
                table: "Superheroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alterEgoName",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "catchphrase",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "primaryAbility",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "secondaryAbility",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "superheroName",
                table: "Superheroes");
        }
    }
}
