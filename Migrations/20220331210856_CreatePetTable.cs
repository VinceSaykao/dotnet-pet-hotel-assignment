using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace dotnet_bakery.Migrations
{
    public partial class CreatePetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetOwnersTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetOwnersTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetsTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    checkedInAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BreedTypes = table.Column<int>(type: "integer", nullable: false),
                    ColorTypes = table.Column<int>(type: "integer", nullable: false),
                    petOwnerById = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetsTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetsTable_PetOwnersTable_petOwnerById",
                        column: x => x.petOwnerById,
                        principalTable: "PetOwnersTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PetsTable_petOwnerById",
                table: "PetsTable",
                column: "petOwnerById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PetsTable");

            migrationBuilder.DropTable(
                name: "PetOwnersTable");
        }
    }
}
