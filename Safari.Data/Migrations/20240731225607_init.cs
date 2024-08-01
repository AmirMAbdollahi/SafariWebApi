using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Safari.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Martyrs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    FatherFirstName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    BirthDate = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    MartyrDate = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Age = table.Column<short>(type: "SMALLINT", nullable: true),
                    Education = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Job = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    BurialPlace = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    MartyrPlace = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    MissionName = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    PhotoFileUrl = table.Column<string>(type: "VARCHAR(500)", nullable: true),
                    Marriage = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    TestamentText = table.Column<string>(type: "VARCHAR(500)", nullable: true),
                    TestamentFileUrl = table.Column<string>(type: "VARCHAR(500)", nullable: true),
                    Bio = table.Column<string>(type: "VARCHAR(300)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Martyrs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    FirstName = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    LastName = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "VARCHAR(11)", nullable: false),
                    MartyrId = table.Column<int>(type: "int", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Martyr",
                        column: x => x.MartyrId,
                        principalTable: "Martyrs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_MartyrId",
                table: "Comments",
                column: "MartyrId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Martyrs");
        }
    }
}
