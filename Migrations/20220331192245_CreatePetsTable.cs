using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_bakery.Migrations
{
    public partial class CreatePetsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "breedTypes",
                table: "PetsTable",
                newName: "BreedTypes");

            migrationBuilder.AlterColumn<DateTime>(
                name: "checkedInAt",
                table: "PetsTable",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BreedTypes",
                table: "PetsTable",
                newName: "breedTypes");

            migrationBuilder.AlterColumn<string>(
                name: "checkedInAt",
                table: "PetsTable",
                type: "text",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");
        }
    }
}
