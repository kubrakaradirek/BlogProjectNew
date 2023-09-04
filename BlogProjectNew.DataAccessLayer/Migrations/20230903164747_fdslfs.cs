using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogProjectNew.DataAccessLayer.Migrations
{
    public partial class fdslfs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AboutDetails1",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutDetails2",
                table: "Abouts");

            migrationBuilder.DropColumn(
                name: "AboutImage1",
                table: "Abouts");

            migrationBuilder.RenameColumn(
                name: "AboutMapLocation",
                table: "Abouts",
                newName: "AboutImage");

            migrationBuilder.RenameColumn(
                name: "AboutImage2",
                table: "Abouts",
                newName: "AboutDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutImage",
                table: "Abouts",
                newName: "AboutMapLocation");

            migrationBuilder.RenameColumn(
                name: "AboutDetails",
                table: "Abouts",
                newName: "AboutImage2");

            migrationBuilder.AddColumn<string>(
                name: "AboutDetails1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutDetails2",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AboutImage1",
                table: "Abouts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
