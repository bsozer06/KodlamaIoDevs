﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KodlamaIoDevs.Persistance.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProgrammingLanguages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgrammingLanguages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProgrammingLanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Technologies_ProgrammingLanguages_ProgrammingLanguageId",
                        column: x => x.ProgrammingLanguageId,
                        principalTable: "ProgrammingLanguages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Javascript" });

            migrationBuilder.InsertData(
                table: "ProgrammingLanguages",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "C#" });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name", "ProgrammingLanguageId" },
                values: new object[] { 1, "Angular", 1 });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name", "ProgrammingLanguageId" },
                values: new object[] { 2, "ReactJS", 1 });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name", "ProgrammingLanguageId" },
                values: new object[] { 3, "EntityFramework", 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Technologies_ProgrammingLanguageId",
                table: "Technologies",
                column: "ProgrammingLanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Technologies");

            migrationBuilder.DropTable(
                name: "ProgrammingLanguages");
        }
    }
}
