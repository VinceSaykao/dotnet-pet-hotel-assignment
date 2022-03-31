using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_bakery.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PetsTable",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "PetsTable",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "Breed",
                table: "PetsTable",
                newName: "breed");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PetsTable",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "petOwner",
                table: "PetsTable",
                newName: "petOwnerById");

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
                name: "color",
                table: "PetsTable",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "breed",
                table: "PetsTable",
                newName: "Breed");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PetsTable",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "petOwnerById",
                table: "PetsTable",
                newName: "petOwner");
        }
    }
}
