using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_bakery.Migrations
{
    public partial class CreateBakerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "checkedInAt",
                table: "PetsTable");

            migrationBuilder.DropColumn(
                name: "emailAddress",
                table: "PetOwnersTable");

            migrationBuilder.DropColumn(
                name: "petCount",
                table: "PetOwnersTable");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PetsTable",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "ColorTypes",
                table: "PetsTable",
                newName: "colorTypes");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "PetsTable",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "BreedTypes",
                table: "PetsTable",
                newName: "breedTypes");

            migrationBuilder.RenameColumn(
                name: "Breed",
                table: "PetsTable",
                newName: "breed");

            migrationBuilder.RenameColumn(
                name: "petOwnderid",
                table: "PetsTable",
                newName: "petOwnerById");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PetOwnersTable",
                newName: "name");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PetsTable_PetOwnersTable_petOwnerById",
                table: "PetsTable");

            migrationBuilder.DropIndex(
                name: "IX_PetsTable_petOwnerById",
                table: "PetsTable");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "PetsTable",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "colorTypes",
                table: "PetsTable",
                newName: "ColorTypes");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "PetsTable",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "breedTypes",
                table: "PetsTable",
                newName: "BreedTypes");

            migrationBuilder.RenameColumn(
                name: "breed",
                table: "PetsTable",
                newName: "Breed");

            migrationBuilder.RenameColumn(
                name: "petOwnerById",
                table: "PetsTable",
                newName: "petOwnderid");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "PetOwnersTable",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "checkedInAt",
                table: "PetsTable",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "emailAddress",
                table: "PetOwnersTable",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "petCount",
                table: "PetOwnersTable",
                type: "integer",
                nullable: true);
        }
    }
}
