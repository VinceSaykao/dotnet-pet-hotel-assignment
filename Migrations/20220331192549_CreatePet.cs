using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace dotnet_bakery.Migrations
{
    public partial class CreatePet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetsTable_PetOwnersTable_petOwnerById",
                table: "PetsTable");

            migrationBuilder.DropIndex(
                name: "IX_PetsTable_petOwnerById",
                table: "PetsTable");

            migrationBuilder.DropColumn(
                name: "breed",
                table: "PetsTable");

            migrationBuilder.DropColumn(
                name: "color",
                table: "PetsTable");

            migrationBuilder.DropColumn(
                name: "petOwnderid",
                table: "PetsTable");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "PetsTable",
                type: "text",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "PetsTable",
                type: "integer",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "breed",
                table: "PetsTable",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "color",
                table: "PetsTable",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "petOwnderid",
                table: "PetsTable",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PetsTable_petOwnerById",
                table: "PetsTable",
                column: "petOwnerById");

            migrationBuilder.AddForeignKey(
                name: "FK_PetsTable_PetOwnersTable_petOwnerById",
                table: "PetsTable",
                column: "petOwnerById",
                principalTable: "PetOwnersTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
