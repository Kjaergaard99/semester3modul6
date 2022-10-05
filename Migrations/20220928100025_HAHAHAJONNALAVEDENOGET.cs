using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace semester3modul6.Migrations
{
    public partial class HAHAHAJONNALAVEDENOGET : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
    name: "Titel",
    table: "Tasks",
    nullable: true);
            migrationBuilder.Sql(
            @"
    UPDATE Tasks
    SET Titel = Name || ' ' || Category;
");
            // TODO: Drop de to gamle kolonner
            migrationBuilder.DropColumn(
    name: "Name",
    table: "Tasks");
            migrationBuilder.DropColumn(
    name: "Category",
    table: "Tasks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titel",
                table: "Tasks");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
